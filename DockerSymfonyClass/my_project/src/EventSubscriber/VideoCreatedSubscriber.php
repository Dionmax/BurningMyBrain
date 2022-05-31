<?php

namespace App\EventSubscriber;

use Symfony\Component\EventDispatcher\EventSubscriberInterface;
use Symfony\Component\HttpKernel\Event\ResponseEvent;
use Symfony\Component\HttpKernel\KernelEvents;
use Symfony\Component\HttpFoundation\Response;

class VideoCreatedSubscriber implements EventSubscriberInterface
{
    public function onVideoCreatedEvent($event)
    {
        dump($event->video->title);
    }

    public function onKernelResponse1(ResponseEvent $event)
    {
        $response = new Response('dupa1');
//         $event->setResponse($response);
        dump('1');
    }

    public function onKernelResponse2(ResponseEvent $event)
    {
        $response = new Response('dupa2');
        // $event->setResponse($response);
        dump('2');
    }

    public static function getSubscribedEvents()
    {
        return [
            //    'video.created.event' => 'onVideoCreatedEvent',
            //    KernelEvents::RESPONSE => [

            //        ['onKernelResponse1', 2],
            //        ['onKernelResponse2', 1],
            //    ]
        ];
    }
}
