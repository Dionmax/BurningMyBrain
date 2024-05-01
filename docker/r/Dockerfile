FROM jupyter/r-notebook

COPY . /usr/local/src/myscripts

WORKDIR /usr/local/src/myscripts

CMD ["Rscript", "myscript.R"]

RUN Rscript -e 'install.packages("languageserver", repos = "http://cran.us.r-project.org")'

RUN Rscript -e 'install.packages("IRkernel", repos="http://cran.us.r-project.org")'

RUN Rscript -e 'IRkernel::installspec()'

USER root
# Install Git
RUN apt-get update && apt-get install -y git
