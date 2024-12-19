Here is the complete documentation, including the architecture and dashboard details, written in Markdown format for GitHub:


---

Message Router Services Documentation

Table of Contents

1. Overview


2. Architecture Diagram


3. Dashboard Documentation

Messages Status

External Request Status



4. Monitoring Messages by Source


5. Best Practices


6. Mermaid Diagram Source




---

Overview

The Message Router Services provide a seamless message processing pipeline that integrates Cloud Pub/Sub and Edge Pub/Sub, routes messages to external APIs, and handles retries for reliability. This document covers:

The architecture of the service.

The functionality and components of the Message Router Dashboard.

Best practices for monitoring and troubleshooting.



---

Architecture Diagram

The architecture is summarized as follows:

Messages flow between Cloud Pub/Sub and Edge Pub/Sub through the Message Router Service.

Processed messages are routed to downstream services via APIGEE.

Retry mechanisms ensure delivery reliability.


Below is the architecture represented in Mermaid:

Mermaid Diagram

flowchart TB
  %% Nodes Definition
  subgraph GCP_Edge["GCP Edge"]
    DS[DataSync pub/sub]
    EDS[Edge Decryption Service]
  end

  subgraph GCP_Selling["GCP Selling"]
    SMR[Selling Message Router]
    SSC[<b>Selling Service Cloud</b>]
    SPS[<b>Selling Pub/Sub (Encrypted KMS)</b>]
    SMR -->|Pull| SSC
    SMR -->|Pull| SPS
  end

  subgraph Edge_Store["Edge Store"]
    E_DS[DataSync]
    SSE[selling service edge]
    ENC[Encryption Service]
  end

  subgraph GCP_BSL["GCP BSL"]
    API[APIGEE]
    Order[OrderService]
    Pharma[Pharmacy Service]
  end

  %% Edges
  DS --> EDS
  DS -->|SA1| SSC
  SSC --> SPS
  SPS -->|2 Day Retry| API
  API --> Order
  API --> Pharma

  %% Edge Store Connections
  E_DS --> SSE
  SSE --> ENC -->|1 Try| SPS


---

Dashboard Documentation

The Message Router Services Dashboard provides real-time monitoring of system health and performance. Key components include message statuses and external request metrics.

1. Messages Status

Current Unacked Messages:

Tracks unacknowledged messages for the Selling Cloud Pub/Sub subscription.

Displayed as a gauge chart:

Green Zone: Low unacked messages (normal operation).

Orange Zone: Moderate unacked messages (requires attention).

Red Zone: High unacked messages (investigation required).


Note: For Edge Pub/Sub metrics, use the Edge GCP built-in subscription dashboard.


Unacked Messages Timeline:

Visualizes trends for unacknowledged messages over time for the Selling Cloud Pub/Sub subscription.



2. External Request Status

Scope:

Captures data for both Cloud Pub/Sub and Edge Pub/Sub sources.

Includes metrics for:

Successful Requests: Requests successfully processed by downstream services.

Failed Requests: Requests that failed due to external API or connectivity issues.



How It Works:

Aggregates external request data from messages originating from Cloud Pub/Sub and Edge Pub/Sub.


Metrics:

Successful External Requests: A time series showing successfully processed requests.

Failed External Requests: A time series showing failed API calls.

External Requests (1-Minute Average): Average external requests processed every minute.




---

Monitoring Messages by Source


---

Best Practices

1. External Request Monitoring:

Use the External Requests section to monitor the health of external requests from both Cloud Pub/Sub and Edge Pub/Sub.

Investigate spikes in failed requests to identify system or API issues.



2. Message Source-Specific Monitoring:

For Selling Cloud Pub/Sub unacknowledged messages: Use this dashboard.

For Edge Pub/Sub metrics: Open the Edge GCP built-in Pub/Sub subscription dashboard.





---

Mermaid Diagram Source

If you need to edit the architecture, use the Mermaid source below:

flowchart TB
  %% Nodes Definition
  subgraph GCP_Edge["GCP Edge"]
    DS[DataSync pub/sub]
    EDS[Edge Decryption Service]
  end

  subgraph GCP_Selling["GCP Selling"]
    SMR[Selling Message Router]
    SSC[<b>Selling Service Cloud</b>]
    SPS[<b>Selling Pub/Sub (Encrypted KMS)</b>]
    SMR -->|Pull| SSC
    SMR -->|Pull| SPS
  end

  subgraph Edge_Store["Edge Store"]
    E_DS[DataSync]
    SSE[selling service edge]
    ENC[Encryption Service]
  end

  subgraph GCP_BSL["GCP BSL"]
    API[APIGEE]
    Order[OrderService]
    Pharma[Pharmacy Service]
  end

  %% Edges
  DS --> EDS
  DS -->|SA1| SSC
  SSC --> SPS
  SPS -->|2 Day Retry| API
  API --> Order
  API --> Pharma

  %% Edge Store Connections
  E_DS --> SSE
  SSE --> ENC -->|1 Try| SPS


---

This Markdown file is fully compatible with GitHub and can be uploaded to your repository. Let me know if further edits are required!

