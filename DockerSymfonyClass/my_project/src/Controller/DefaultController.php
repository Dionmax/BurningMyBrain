<?php

namespace App\Controller;

use App\Entity\Address;
use App\Entity\Author;
use App\Entity\User;
use App\Entity\Video;
use App\Form\VideoFormType;
use App\Services\MyService;
use Doctrine\Persistence\ManagerRegistry;
use Exception;
use Swift_Mailer;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Cache\Adapter\FilesystemAdapter;
use Symfony\Component\Cache\Adapter\TagAwareAdapter;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class DefaultController extends AbstractController
{
    /**
     * @Route("/", name="app_default")
     * @param ManagerRegistry $doctrine
     * @return Response
     */
    public function index(ManagerRegistry $doctrine): Response
    {

//        //Create names in database example
//        $names = [
//            'Keanu Correa DF',
//            'Unique Stull DF', 'Chase Millan DF',
//            'Kaylea Parnell DF',
//            'Keshawn Hester DF',
//            'Myah Jarrett DF',
//            'Naomi Fanning DF',
//            'Corrine Witt DF',
//            'Bridger Marcum DF',
//            'Briana Mortensen DF'
//        ];
//
//        $entityManager = $doctrine->getManager();
//
//        foreach ($names as $name) {
//            $user = new User();
//
//            $user->setName($name);
//
//            $entityManager->persist($user);
//        }

//        $entityManager->flush();

        // ---- Video

//        $entityManager = $doctrine->getManager();
//
//        $user = new User();
//
//        $user->setName("User Video");
//
//        for ($i = 1; $i <= 3; $i++) {
//            $video = new Video();
//
//            $video->setTitle('Video title - ' . $i);
//
//            $user->addVideo($video);
//
//            $entityManager->persist($video);
//        }
//
//        $entityManager->persist($user);
//
//        $entityManager->flush();

        // ---- Address

//        $entityManager = $doctrine->getManager();
//
//        $user = new User();
//
//        $user->setName("User Adress");
//
//
//        for ($i = 1; $i <= 3; $i++) {
//            $video = new Video();
//
//            $video->setTitle('Video title - ' . $i);
//
//            $user->addVideo($video);
//
//            $entityManager->persist($video);
//        }
//
//        $address = new Address();
//
//        $address->setStreet('Nowhere turning left');
//
//        $address->setNumber(1);
//
//        $user->setAddress($address);
//
//        $entityManager->persist($address);
//
//        $entityManager->persist($user);
//
//        $entityManager->flush();

        //---- Followed

//        $entityManager = $doctrine->getManager()->getRepository(User::class);
//
//        /**
//         * @var $user11 User
//         */
//        $user11 = $entityManager->find(11);
//        $user12 = $entityManager->find(12);
//        $user13 = $entityManager->find(13);
//        $user14 = $entityManager->find(14);
//        $user15 = $entityManager->find(15);
//
//        $user11->addFollowed($user12);
//        $user11->addFollowed($user13);
//        $user11->addFollowed($user14);
//        $user11->addFollowed($user15);
//
//        $entityManager2 = $doctrine->getManager();
//
//        $entityManager2->flush();
//
//        dump($user11->getFollowed()->count());
//        dump($user11->getFollowing()->count());

        //------ Morphic Query
//        $author = $doctrine->getRepository(Author::class)->findByWithPdf(1);
//        dump($author);

        //------ Cache FilesystemAdapter
//        $cache = new FilesystemAdapter();
//
//        $posts = $cache->getItem('database.get_posts');
//
//        if (!$posts->isHit()) {
//            $posts->set(serialize((['post 1', 'post 2', 'post 3'])));
//            $posts->expiresAfter(5);
//            $cache->save($posts);
//        }
//
//        var_dump(unserialize($posts->get()));
//
//        $cache->deleteItem('database.get_posts');
//        $cache->clear();

        //------ Cache TagAwareAdapter
//        $cache = new TagAwareAdapter(
//            new FilesystemAdapter()
//        );
//
//        $posts = $cache->getItem('computer');
//
//        if (!$posts->isHit()) {
//            $posts->set(serialize((['post 1', 'post 2', 'post 3'])));
//            $posts->tag(['posts', 'test']);
//            $cache->save($posts);
//        }
//
//        var_dump(unserialize($posts->get()));
//
//        $cache->invalidateTags(['test']); // Delete by Tags


        // ---------------------- Emails --------------------------


        $users = $doctrine->getRepository(User::class)->findAll();

        return $this->render('default/index.html.twig', [
            'controller_name' => 'DefaultController',
            'users' => $users,
        ]);
    }

    /**
     * @Route("/user/{id}", name="app_default")
     * @param User $user
     * @return Response
     */
    public function getUserAction(User $user): Response
    {
        return $this->render('default/show.html.twig', [
            'controller_name' => 'DefaultController',
            'user' => $user,
            'videos' => $user->getVideos(),
            'address' => $user->getAddress(),
        ]);
    }

    /**
     * @Route("/form/video", name="app_default")
     * @param ManagerRegistry $doctrine
     * @param Request $request
     * @return Response
     * @throws Exception
     */
    public function getFormAction(ManagerRegistry $doctrine, Request $request): Response
    {
        $manager = $doctrine->getManager();

        $author = new Author();
        $author->setName('Test man');
        $manager->persist($author);

//        $videos = $doctrine->getRepository(Video::class)->findAll();
//        dump($videos);

        $video = new Video();

        $video->setDuration(1);
        $video->setAuthor($author);
        $video->setFormat('mp4');
        $video->setDescription('test');
        $video->setFilename('Test Video');
        $video->setSize(1);

        $form = $this->createForm(VideoFormType::class, $video);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {

            $file = $form->get('file')->getData();
            $fileName = sha1(random_bytes(14)) . '.' . $file->guessExtension();

            $file->move(
                $this->getParameter('videos_directory'),
                $fileName
            );

            $video->setFile($fileName);
            $manager->persist($video);
            $manager->flush();
        }

        dump($video);

        return $this->render('default/show_form.html.twig', [
            'form' => $form->createView(),
        ]);
    }

    /**
     * @Route("/email", name="app_default")
     * @param Swift_Mailer $mailer
     * @return Response
     */
    public function sendEmailAction(Swift_Mailer $mailer): Response
    {
        $message = (new \Swift_Message('Hello Email'))
            ->setFrom('send@example.com')
            ->setTo('recipient@example.com')
            ->setBody(
                $this->renderView(
                    'default/email.html.twig',
                    array('name' => 'Robert')
                ),
                'text/html'
            );

        $mailer->send($message);

        return $this->render('default/email.html.twig', [
            'controller_name' => 'DefaultController',
        ]);
    }

}
