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
            'Keanu Correa DF',
            'Unique Stull DF', 'Chase Millan DF',
            'Kaylea Parnell DF',
            'Keshawn Hester DF',
            'Myah Jarrett DF',
            'Naomi Fanning DF',
            'Corrine Witt DF',
            'Bridger Marcum DF',
            'Briana Mortensen DF'
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
