<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use SoftUniBlogBundle\Entity\Article;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;

class DefaultController extends Controller
{
    /**
     * @Route("/", name="blog_index")
     * @return Response
     */
    public function indexAction()
    {
        $articles= $this->getDoctrine()->getRepository(Article::class)->findBy([], array('dateAdded' => 'DESC'));

        return $this->render('blog/index.html.twig', ['articles'=>$articles]);
    }
}
