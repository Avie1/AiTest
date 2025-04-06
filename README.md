# Cart Service Event Integration Guide

External services can receive real-time event notifications from the Cart Service by exposing a compatible Web API and registering their endpoint in the Cart Service Helm configuration.

## Supported Events

The Cart Service emits events for various cart lifecycle changes:

- Cart Created
- Item Added
- Tender Added
- Cart Closed
- [Add more events as needed]

## Integration Steps

### 1. Implement the Required Web API

Your external service must expose a Web API with endpoints to handle the cart event payloads. The expected contract for these endpoints is defined in the Swagger file provided below.

> **Note**: You are responsible for hosting the Web API and ensuring it's reachable from the Cart Service environment.

**Example Implementation Contracts:**

- POST `/cart-event/created`
- POST `/cart-event/item-added`
- POST `/cart-event/tender-added`
- POST `/cart-event/closed`

Each endpoint should accept a JSON payload corresponding to the specific event type.

### 2. Configure Cart Service to Send Events

Update the Cart Service Helm configuration to register your external service endpoint(s). The Cart Service supports dynamic event delivery via configuration.

Example configuration (`values.yaml`):

```yaml
eventSubscribers:
  - name: my-external-service
    events:
      - cart-created
      - item-added
      - tender-added
      - cart-closed
    endpoint: https://your-service.domain.com/cart-event
