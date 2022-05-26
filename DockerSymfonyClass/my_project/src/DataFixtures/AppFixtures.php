<?php

namespace App\DataFixtures;

use App\Entity\User;
use Doctrine\Bundle\FixturesBundle\Fixture;
use Doctrine\Persistence\ObjectManager;

class AppFixtures extends Fixture
{
    public function load(ObjectManager $manager): void
    {
        // $product = new Product();
        // $manager->persist($product);

        $names = [
            'Keanu Correa',
            'Unique Stull', 'Chase Millan',
            'Kaylea Parnell',
            'Keshawn Hester',
            'Myah Jarrett',
            'Naomi Fanning',
            'Corrine Witt',
            'Bridger Marcum',
            'Briana Mortensen'
        ];

        foreach ($names as $name) {
            $user = new User();

            $user->setName($name);

            $manager->persist($user);
        }

        $manager->flush();

        $manager->flush();
    }
}
