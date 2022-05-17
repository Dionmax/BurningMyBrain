FROM php:7.4-fpm

RUN apt-get clean
RUN apt-get update

RUN apt-get install -y zlib1g-dev libpq-dev git libicu-dev libxml2-dev libzip-dev zip nodejs npm \
    && docker-php-ext-configure intl \
    && docker-php-ext-install intl \
    && docker-php-ext-configure pgsql -with-pgsql=/usr/local/pgsql \
    && docker-php-ext-install pdo pdo_pgsql pgsql \
    && docker-php-ext-install zip xml

RUN curl --insecure https://getcomposer.org/composer.phar -o /usr/bin/composer && chmod +x /usr/bin/composer

RUN composer self-update

# Set timezone
RUN rm /etc/localtime
RUN ln -s /usr/share/zoneinfo/Brazil/East/America/Sao_Paulo /etc/localtime
RUN "date"

WORKDIR /var/www/symfony

RUN npm install
