<?php

namespace App\Entity;

use App\Repository\VideoRepository;
use Doctrine\ORM\Mapping as ORM;
use Symfony\Component\Validator\Constraints as Assert;

/**
 * @ORM\Entity(repositoryClass=VideoRepository::class)
 */
class Video extends File
{
    /**
     * @ORM\Column(type="string", length=255)
     * @Assert\NotBlank()
     * @Assert\Length(min = 2, max = 10, minMessage="Video title must be at least {{ limit }} characters long", maxMessage="Video title must cannot be longer than {{ limit }} characters")
     */
    private $title;

    /**
     * @ORM\ManyToOne(targetEntity=User::class, inversedBy="videos")
     */
    private $owner;

    /**
     * @ORM\Column(type="string", length=255)
     */
    private $format;

    /**
     * @ORM\Column(type="integer")
     */
    private $duration;

    /**
     * @ORM\Column(type="datetime")
     * @Assert\NotBlank()
     * @Assert\Type("\DateTime")
     */
    private $createdAt;

    /**
     * @ORM\Column(type="string", length=255)
     * @Assert\File(
     *     maxSize="1024",
     * mimeTypes = {"video/mp4", "application/pdf", "application/x-pdf"},
     * mimeTypesMessage = "Please upload a valid video"
     * )
     */
    private $file;

    /**
     * @ORM\ManyToOne(targetEntity=SecurityUser::class, inversedBy="videos")
     */
    private $securityUser;

    public function getTitle(): ?string
    {
        return $this->title;
    }

    public function setTitle(string $title): self
    {
        $this->title = $title;

        return $this;
    }

    public function getOwner(): ?User
    {
        return $this->owner;
    }

    public function setOwner(?User $owner): self
    {
        $this->owner = $owner;

        return $this;
    }

    public function getFormat(): ?string
    {
        return $this->format;
    }

    public function setFormat(string $format): self
    {
        $this->format = $format;

        return $this;
    }

    public function getDuration(): ?int
    {
        return $this->duration;
    }

    public function setDuration(int $duration): self
    {
        $this->duration = $duration;

        return $this;
    }

    public function getCreatedAt(): ?\DateTime
    {
        return $this->createdAt;
    }

    public function setCreatedAt(\DateTime $createdAt): self
    {
        $this->createdAt = $createdAt;

        return $this;
    }

    public function getFile(): ?string
    {
        return $this->file;
    }

    public function setFile(string $file): self
    {
        $this->file = $file;

        return $this;
    }

    public function getSecurityUser(): ?SecurityUser
    {
        return $this->securityUser;
    }

    public function setSecurityUser(?SecurityUser $securityUser): self
    {
        $this->securityUser = $securityUser;

        return $this;
    }
}
