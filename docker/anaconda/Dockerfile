# Base image
FROM continuumio/anaconda3

# Set working directory
WORKDIR /app

# Copy the current directory contents into the container at /app
COPY . /app

# Set the default command to run when the container starts
CMD ["python", "app.py"]

# Update conda
RUN conda update -n base conda

# Update all packages
RUN conda update --all

# Install any additional packages if needed
# RUN conda install <package_name>