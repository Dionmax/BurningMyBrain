# Use an official Node.js runtime as the base image
FROM node:22

# Set the working directory inside the container
WORKDIR /app

# Copy package.json and package-lock.json to the working directory
COPY package*.json ./

# Copy the rest of the application code to the working directory
COPY . .

# Expose a port (if your application needs it)
EXPOSE 3000

# Define the command to run your application
CMD [ "npm", "start" ]

# Install Git
RUN apt-get update && apt-get install -y git