<?php

namespace App\Controller;

use App\Entity\User;
use Doctrine\Persistence\ManagerRegistry;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
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

        //Create names in database example
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
//
//        $entityManager->flush();

        $users = $doctrine->getRepository(User::class)->findAll();

        return $this->render('default/index.html.twig', [
            'controller_name' => 'DefaultController',
            'users' => $users,
        ]);
    }
}
