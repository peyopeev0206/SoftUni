<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use SoftUniBlogBundle\Entity\Article;
use SoftUniBlogBundle\Entity\User;
use SoftUniBlogBundle\Form\UserType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;

class UserController extends Controller
{
    /**
     * @Route("/register", name="user_register")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function registerAction(Request $request)
    {
        $user = new User();
        $form = $this->createForm(UserType::class, $user);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            if ($this->getDoctrine()->getRepository(User::class)->findBy(['email' => $user->getEmail()])) {
                return $this->render("user/register.html.twig", array('form' => $form->createView(), 'err' => "That email is already registered!"));
            }

            $password = $this->get('security.password_encoder')
                ->encodePassword($user, $user->getPassword());

            $user->setPassword($password);

            $em = $this->getDoctrine()->getManager();
            $em->persist($user);
            $em->flush();

            return $this->redirectToRoute('security_login');

        }

        return $this->render("user/register.html.twig",
            array('form' => $form->createView(), 'err' => null)
        );

    }

    /**
     * @param string $username
     * @Route("/profile/{username}", name="user_profile")
     * @return Response
     */
    public function profileAction($username)
    {
        $user = $this->getDoctrine()->getRepository(User::class)->findOneBy(['fullName' => $username]);

        if ($user) {
            $articles = $this->getDoctrine()->getRepository(Article::class)->findBy(['authorId' => $user->getId()], ['dateAdded' => 'DESC']);
            return $this->render("user/profile.html.twig", ['user' => $user, 'articles' => $articles]);
        } else {
            return $this->render('blog/error.html.twig', ['message' => "There is no such user!"]);
        }
    }
}
