# Base image
FROM continuumio/anaconda3

# Set working directory
WORKDIR /app

# Copy the current directory contents into the container at /app
COPY . /app

# Install any additional packages if needed
# RUN conda install <package_name>

# Set the default command to run when the container starts
CMD ["python", "app.py"]