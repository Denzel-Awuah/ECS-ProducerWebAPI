## .NET 8 Web API AWS System with ECS, EC2, SQS, Lambda and S3
A .NET 8 Web API that Produces messages and sends them to an SQS Queue. The messages in the SQS queue are then consumed by an AWS .NET Lambda function that processes the messages and stores updates into an S3 bucket.

## Deployment 
The .NET Web API application was containerized using Docker, then the image is pushed to a repository in Elastic Container Registry. The image was then pulled from Elastic Container Registry and deployed to Amazon Elastic Container Services (ECS).
The Elastic Container Services Cluster was deployed using AWS EC2 Instances. The Cluster deployment also contained an Application Load Balancer to balance the traffic coming into the cluster.

