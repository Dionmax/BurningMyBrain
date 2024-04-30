FROM r-base

COPY . /usr/local/src/myscripts

WORKDIR /usr/local/src/myscripts

CMD ["Rscript", "myscript.R"]

RUN apt-get update && apt-get install -y --no-install-recommends curl

RUN apt-get update && apt-get install -y --no-install-recommends libxml2-dev

RUN Rscript -e 'install.packages("languageserver")'

# Install Git
RUN apt-get update && apt-get install -y git