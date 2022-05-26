<?php

namespace App\DataFixtures;

use App\Entity\Author;
use App\Entity\Pdf;
use App\Entity\Video;
use Doctrine\Bundle\FixturesBundle\Fixture;
use Doctrine\Persistence\ObjectManager;


class InheritanceEntitiesFixtures extends Fixture
{
    public function load(ObjectManager $manager): void
    {
        for ($i = 1; $i <= 2; $i++) {
            $author = new Author();

            $author->setName('Author name' . $i);

            $manager->persist($author);

            for ($j = 1; $j <= 3; $j++) {
                $pdf = new Pdf();

                $pdf->setFilename('pdf ' . $j . ' from author ' . $i);
                $pdf->setDescription('pdf description of user ' . $i);
                $pdf->setSize(5454);
                $pdf->setOrientation('portrait');
                $pdf->setPages(123);
                $pdf->setAuthor($author);
                $manager->persist($pdf);
            }

            for ($k = 1; $k <= 3; $k++) {
                $video = new Video();

                $video->setFilename('video ' . $k . ' from author ' . $i);
                $video->setDescription('video description of user ' . $i);
                $video->setSize(5454);
                $video->setFormat('mpeg-2');
                $video->setDuration(312);
                $video->setAuthor($author);
                $manager->persist($video);
            }
        }

        $manager->flush();
    }
}