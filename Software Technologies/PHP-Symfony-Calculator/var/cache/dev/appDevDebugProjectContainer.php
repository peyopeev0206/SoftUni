<?php

// This file has been auto-generated by the Symfony Dependency Injection Component for internal use.

if (\class_exists(\ContainerGhnanbf\appDevDebugProjectContainer::class, false)) {
    // no-op
} elseif (!include __DIR__.'/ContainerGhnanbf/appDevDebugProjectContainer.php') {
    touch(__DIR__.'/ContainerGhnanbf.legacy');

    return;
}

if (!\class_exists(appDevDebugProjectContainer::class, false)) {
    \class_alias(\ContainerGhnanbf\appDevDebugProjectContainer::class, appDevDebugProjectContainer::class, false);
}

return new \ContainerGhnanbf\appDevDebugProjectContainer(array(
    'container.build_hash' => 'Ghnanbf',
    'container.build_id' => '7e931875',
    'container.build_time' => 1522595695,
));
