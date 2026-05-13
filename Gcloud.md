### List Bindings with Alpha Version

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/cloud-bindings/list

This command uses the alpha version of the access-context-manager to list cloud bindings. Ensure you have the alpha components installed.

```bash
gcloud alpha access-context-manager cloud-bindings list
```

--------------------------------

### Example Access Binding Output (YAML)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/cloud-bindings/list

This is an example of the YAML output format for a Google Cloud user access binding. It details access levels, group keys, and session settings.

```yaml
---
accessLevels:
- accessPolicies/9522/accessLevels/device_trusted
dryRunAccessLevels:
- accessPolicies/9522/accessLevels/specific_location
groupKey: a3dad
name: organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N
sessionSettings:
  sessionLength: 57600s
  sessionLengthEnabled: true
  sessionReauthMethod: LOGIN

```

--------------------------------

### JSON instances file example

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

Instances are read from a local file in JSON format, with each instance on a new line. This format is suitable for structured data.

```json
{"images": [0.0, …, 0.1], "key": 3}
{"images": [0.0, …, 0.1], "key": 2}
…
```

--------------------------------

### Text instances file example

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

Instances are read from a local file in UTF-8 encoded text format, with each instance on a new line. This is useful for simple, non-structured data like CSV.

```text
107,4.9,2.5,4.5,1.7
100,5.7,2.8,4.1,1.3
…
```

--------------------------------

### List VPC Service Controls Supported Services

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/supported-services

Use this command to see all VPC Service Controls supported services. No specific setup or imports are required beyond having the gcloud CLI installed.

```bash
gcloud access-context-manager supported-services list
```

--------------------------------

### Example Access Binding Output with Scoped Settings (YAML)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/cloud-bindings/list

This YAML output demonstrates a more complex access binding configuration, including scoped access settings for different client applications and environments.

```yaml
---
accessLevels:
- accessPolicies/9522/accessLevels/device_trusted
dryRunAccessLevels:
- accessPolicies/9522/accessLevels/specific_location
groupKey: a3dad
name: organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N
scopedAccessSettings:
- activeSettings:
    accessLevels:
    - accessPolicies/9522/accessLevels/device_trusted
  dryRunSettings:
    accessLevels:
    - accessPolicies/9522/accessLevels/specific_location
  scope:
    clientScope:
      restrictedClientApplication:
        clientId: 123.apps.googleusercontent.com
- activeSettings:
    accessLevels:
    - accessPolicies/9522/accessLevels/device_trusted
  dryRunSettings:
    accessLevels:
    - accessPolicies/9522/accessLevels/specific_location
  scope:
    clientScope:
      restrictedClientApplication:
        name: Cloud Console
- activeSettings:
    sessionSettings:
      sessionLength: 57600s
      sessionLengthEnabled: true
      sessionReauthMethod: LOGIN
  scope:
    clientScope:
      restrictedClientApplication:
        clientId: 123.apps.googleusercontent.com
sessionSettings:
  sessionLength: 57600s
  sessionLengthEnabled: true
  sessionReauthMethod: LOGIN

```

--------------------------------

### List AI Platform Jobs

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/jobs/list

Use this command to list all existing AI Platform jobs. No specific setup is required beyond having the gcloud CLI installed and authenticated.

```bash
gcloud ai-platform jobs list
```

--------------------------------

### Configure Private Service Connect (PSC) auto-connections

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Specify consumer project and network pairs for Private Service Connect (PSC) connectivity. Both project and network must be specified. Example: --psc-auto-connections=project=project1,network=projects/vpc-host-project1/global/networks/network1

```bash
--psc-auto-connections=[`network`=`NETWORK`],[`project`=`PROJECT`]
```

```bash
--psc-auto-connections=network=string,project=string
```

```bash
--psc-auto-connections='{"network": "string", "project": "string"}'
```

```bash
--psc-auto-connections=path_to_file.(yaml|json)
```

--------------------------------

### Describe an AlloyDB instance

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/describe

Use this command to get detailed information about an AlloyDB instance. Specify the instance ID, cluster ID, and region. The `--view` flag can be used to control the level of detail returned.

```bash
gcloud alloydb instances describe my-instance --cluster=my-cluster --region=us-central1 --view=BASIC/FULL
```

--------------------------------

### JSON request file example

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

A local file containing the body of a JSON request, which includes a list of instances. This is a common format for sending multiple prediction requests.

```json
{
  "instances": [
    {"x": [1, 2], "y": [3, 4]},
    {"x": [-1, -2], "y": [-3, -4]}
  ]
}
```

--------------------------------

### Describe a custom job

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/custom-jobs/describe

Use this command to get detailed information about a specific custom job. Ensure you provide the job ID and the region where it is located. The `--project` flag can be used to specify the project.

```bash
gcloud ai custom-jobs describe 123 --project=example --region=us-central1
```

--------------------------------

### Describe VPC Service Controls Supported Service

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/supported-services

Use this command to get support information about a specific VPC Service Controls supported service. Replace SERVICE_NAME with the actual service name.

```bash
gcloud access-context-manager supported-services describe SERVICE_NAME
```

--------------------------------

### GET gcloud active-directory peerings list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/peerings/list

Lists all Managed Microsoft AD domain peerings in the given project.

```APIDOC
## GET gcloud active-directory peerings list

### Description
List all Managed Microsoft AD domain peerings in the given project.

### Method
GET

### Endpoint
gcloud active-directory peerings list

### Parameters
#### Query Parameters
- **--filter** (EXPRESSION) - Optional - Apply a Boolean filter EXPRESSION to each resource item to be listed.
- **--limit** (LIMIT) - Optional - Maximum number of resources to list.
- **--page-size** (PAGE_SIZE) - Optional - Maximum number of resources per page.
- **--sort-by** (FIELD,...) - Optional - Comma-separated list of resource field key names to sort by.
- **--uri** (boolean) - Optional - Print a list of resource URIs instead of the default output.

### Request Example
```
gcloud active-directory peerings list --limit=5
```
```

--------------------------------

### Configure database flags

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Set database flags for the instance. Flags can be set with values, or without values for flags like skip_grant_tables. Use on/off for boolean flags. Example: --database-flags max_allowed_packet=55555,skip_grant_tables=,log_output=1

```bash
--database-flags `FLAG`=`VALUE`,[`FLAG`=`VALUE`,...]
```

--------------------------------

### Configure PSC network attachment URI

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Specify the full URI of the network attachment for outbound connectivity from an AlloyDB instance using Private Service Connect (PSC). Example: psc-network-attachment-uri=projects/test-project/regions/us-central1/networkAttachments/my-na

```bash
--psc-network-attachment-uri=`PSC_NETWORK_ATTACHMENT_URI`
```

--------------------------------

### gcloud ai-platform local predict command

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

This command runs prediction locally. Ensure the TensorFlow SDK is installed and specify the model directory along with one of the instance input flags.

```bash
gcloud ai-platform local predict --model-dir=MODEL_DIR --json-instances=JSON_INSTANCES
```

--------------------------------

### Copy a model to a new model ID

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

This command copies a source model and assigns it a new, unique ID in the destination. The new model ID must be between 1 and 63 characters and can only contain lowercase letters, numbers, and hyphens. It cannot start with a number or hyphen.

```bash
gcloud ai models copy --source-model=SOURCE_MODEL --destination-model-id=DESTINATION_MODEL_ID
```

--------------------------------

### gcloud ai-platform local predict

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

Runs prediction locally with the given instances. Requires the TensorFlow SDK to be installed locally. The output format mirrors `gcloud ai-platform predict` (online prediction). Custom prediction routines cannot be used with this command.

```APIDOC
## gcloud ai-platform local predict

### Description
Performs prediction locally with the given instances. Requires the TensorFlow SDK to be installed locally. The output format mirrors `gcloud ai-platform predict` (online prediction). You cannot use this command with custom prediction routines.

### Method
COMMAND

### Endpoint
gcloud ai-platform local predict

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Flags
#### Required Flags
* `--model-dir`=`MODEL_DIR` (string) - Path to the model.

Exactly one of the following must be specified:
* `--json-instances`=`JSON_INSTANCES` (string) - Path to a local file from which instances are read. Instances are in JSON format; newline delimited. This flag accepts "-" for stdin.
* `--json-request`=`JSON_REQUEST` (string) - Path to a local file containing the body of JSON request. This flag accepts "-" for stdin.
* `--text-instances`=`TEXT_INSTANCES` (string) - Path to a local file from which instances are read. Instances are in UTF-8 encoded text format; newline delimited. This flag accepts "-" for stdin.

#### Optional Flags
* `--framework`=`FRAMEWORK` (string) - ML framework used to train this version of the model. If not specified, defaults to 'tensorflow'. `FRAMEWORK` must be one of: `scikit-learn`, `tensorflow`, `xgboost`.
* `--signature-name`=`SIGNATURE_NAME` (string) - Name of the signature defined in the SavedModel to use for this job. Defaults to DEFAULT_SERVING_SIGNATURE_DEF_KEY in https://www.tensorflow.org/api_docs/python/tf/compat/v1/saved_model/signature_constants, which is "serving_default". Only applies to TensorFlow models.

#### Gcloud Wide Flags
These flags are available to all commands: `--access-token-file`, `--account`, `--billing-project`, `--configuration`, `--flags-file`, `--flatten`, `--format`, `--help`, `--impersonate-service-account`, `--log-http`, `--project`, `--quiet`, `--trace-token`, `--user-output-enabled`, `--verbosity`. Run `$ gcloud help` for details.

### Request Example
```bash
gcloud ai-platform local predict \
  --model-dir="/path/to/your/model" \
  --json-instances="/path/to/instances.jsonl"
```

### Response
#### Success Response (200)
Output format mirrors `gcloud ai-platform predict` (online prediction).

#### Response Example
```json
{
  "predictions": [
    [0.1, 0.9],
    [0.8, 0.2]
  ]
}
```

### Variants
* `gcloud alpha ai-platform local predict`
* `gcloud beta ai-platform local predict`
```

--------------------------------

### Describe a Tensorboard with full path

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/tensorboards/describe

Use this command to describe a Tensorboard by providing its full resource path, including project, location, and Tensorboard ID. Ensure the project and region are correctly specified.

```bash
gcloud ai tensorboards describe projects/my-project/locations/us-central1/tensorboards/12345
```

--------------------------------

### List Cloud Access Bindings

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/cloud-bindings/list

Run this command to list all cloud access bindings under your organization. The output is provided in YAML format.

```bash
gcloud access-context-manager cloud-bindings list
```

--------------------------------

### Use beta version of gcloud ai tensorboards describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/tensorboards/describe

This command uses the beta version of the gcloud AI Tensorboards describe command. Beta versions offer features that are close to final but may still undergo changes.

```bash
gcloud beta ai tensorboards describe
```

--------------------------------

### Describe an AlloyDB instance (Beta)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/describe

This command is available in the beta version of the gcloud CLI.

```bash
gcloud beta alloydb instances describe
```

--------------------------------

### Create an access policy with beta version

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy using the beta version of the gcloud access-context-manager component. Beta versions offer more features than stable releases but may still have some instability.

```bash
gcloud beta access-context-manager policies create --organization=organizations/123 --title="My Beta Policy"
```

--------------------------------

### Create an access policy with multiple scopes

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command demonstrates creating an access policy with multiple scopes, such as both a folder and a project. Note that the documentation states only one folder or project can be specified as a scope.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --scopes=folders/345,projects/567 --title="My Multi-Scope Policy"
```

--------------------------------

### Create an access policy with an access token file

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy using an access token from a file. The `--access-token-file` flag allows you to authenticate using a pre-obtained access token.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Access Token Policy" --access-token-file=token.txt
```

--------------------------------

### Beta version of describe command

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/describe

This is an alternative command for describing a Managed Microsoft AD domain using the beta version of the gcloud CLI.

```bash
gcloud beta active-directory domains describe
```

--------------------------------

### Enable connection pooling

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Enable connection pooling for the instance. Use --enable-connection-pooling to enable and --no-enable-connection-pooling to disable.

```bash
--[no-]enable-connection-pooling
```

--------------------------------

### Describe an AlloyDB instance (Alpha)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/describe

This command is available in the alpha version of the gcloud CLI.

```bash
gcloud alpha alloydb instances describe
```

--------------------------------

### Create an access policy with a configuration file

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy using a configuration file. The `--flags-file` flag allows you to specify a file containing command-line flags, which can help in managing complex configurations.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Config File Policy" --flags-file=config.txt
```

--------------------------------

### Use alpha version of gcloud ai tensorboards describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/tensorboards/describe

This command uses the alpha version of the gcloud AI Tensorboards describe command. Alpha versions may include experimental features and are subject to change.

```bash
gcloud alpha ai tensorboards describe
```

--------------------------------

### Deploy a Model Garden model

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/model-garden/models/deploy

Use this command to deploy a model from Model Garden. Ensure you specify the correct model format and project details.

```bash
gcloud ai model-garden models deploy --model=google/gemma2@gemma-2-9b --project=example --region=us-central1
```

--------------------------------

### gcloud beta ai custom-jobs describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/custom-jobs/describe

This is a beta version of the command to describe a custom job. It offers more stability than alpha but may still evolve.

```bash
gcloud beta ai custom-jobs describe
```

--------------------------------

### Create an access policy with a trace token

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and includes a trace token for debugging. The `--trace-token` flag is useful for tracking requests through the Google Cloud infrastructure.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Trace Token Policy" --trace-token=my-trace-id
```

--------------------------------

### List AD Domain Peerings with Limit

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/peerings/list

Use this command to list a specified number of AD domain peerings in your project. Ensure your account has the necessary permissions.

```bash
gcloud active-directory peerings list --limit=5
```

--------------------------------

### Create an access policy for the entire organization

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

Use this command to create a new access policy that applies to your entire organization. Ensure you have the correct organization ID and a descriptive title.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Policy"
```

--------------------------------

### gcloud beta ai models list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/list

This is a beta version of the command. It offers more features than the stable version but may still be subject to change.

```bash
gcloud beta ai models list
```

--------------------------------

### Describe a Tensorboard using flags

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/tensorboards/describe

This command describes a Tensorboard using its ID and specifying the region and project via flags. This is a more concise way to target a specific Tensorboard when the full path is not provided.

```bash
gcloud ai tensorboards describe 12345
```

--------------------------------

### Create a Service Perimeter

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

Use the `create` command to establish a new service perimeter.

```APIDOC
## POST /api/access-context-manager/v1/perimeters

### Description
Creates a new service perimeter.

### Method
POST

### Endpoint
`/api/access-context-manager/v1/perimeters`

### Parameters
#### Query Parameters
- **parent** (string) - Required - The name of the parent resource (e.g., `organizations/123`).

#### Request Body
- **name** (string) - Required - The name of the Service Perimeter to create. Example: `projects/my-project/servicePerimeters/myPerimeter`.
- **title** (string) - Optional - A human-readable title for the Service Perimeter.
- **resources** (array of strings) - Optional - A list of Google Cloud resource names that are part of this Service Perimeter. Example: `["projects/12345"]`.
- **restrictedServices** (array of strings) - Optional - A list of Google Cloud services that are restricted from being accessed from outside the perimeter. Example: `["storage.googleapis.com"]`.
- **ingressPolicies** (array of objects) - Optional - Defines the conditions for traffic ingress into the perimeter.
- **egressPolicies** (array of objects) - Optional - Defines the conditions for traffic egress from the perimeter.

### Request Example
```json
{
  "name": "organizations/123/locations/global/servicePerimeters/myPerimeter",
  "title": "My Perimeter",
  "resources": ["projects/12345"]
}
```

### Response
#### Success Response (200)
- **name** (string) - The resource name of the Service Perimeter.
- **title** (string) - The human-readable title of the Service Perimeter.
- **resources** (array of strings) - The list of Google Cloud resources included in the perimeter.
- **restrictedServices** (array of strings) - The list of restricted services.
- **ingressPolicies** (array of objects) - The ingress policies.
- **egressPolicies** (array of objects) - The egress policies.

#### Response Example
```json
{
  "name": "organizations/123/locations/global/servicePerimeters/myPerimeter",
  "title": "My Perimeter",
  "resources": ["projects/12345"],
  "restrictedServices": [],
  "ingressPolicies": [],
  "egressPolicies": []
}
```
```

--------------------------------

### Beta version of gcloud ai models copy

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

This command is a beta version for copying AI models. It offers more stability than alpha but may still undergo changes.

```bash
gcloud beta ai models copy
```

--------------------------------

### Create an access policy with HTTP logging

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and enables HTTP logging. The `--log-http` flag is useful for debugging by showing the raw HTTP requests and responses.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My HTTP Log Policy" --log-http
```

--------------------------------

### List AlloyDB Users (Beta)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/list

This command is part of the beta release for managing AlloyDB users. It offers more stability than alpha but may still evolve.

```bash
gcloud beta alloydb users list
```

--------------------------------

### Create an access policy asynchronously

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and returns immediately without waiting for the operation to complete. This is useful for scripting or when you don't need to monitor the creation process in real-time.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Policy" --async
```

--------------------------------

### Create an access policy with a billing project

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and specifies a billing project. The `--billing-project` flag is used to associate the operation with a specific billing project.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Billing Project Policy" --billing-project=my-billing-project
```

--------------------------------

### Deploy Model to Vertex AI

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/model-garden/models/deploy

This snippet demonstrates how to deploy a model from the Model Garden to Vertex AI, specifying various configuration options.

```APIDOC
## POST /v1/projects/{projectId}/locations/{locationId}/endpoints/{endpointId}:deployModel

### Description
Deploys a model from the Model Garden to a Vertex AI endpoint.

### Method
POST

### Endpoint
`/v1/projects/{projectId}/locations/{locationId}/endpoints/{endpointId}:deployModel`

### Parameters
#### Query Parameters
- `--container-image` (string) - Required - URI of the Model serving container file in the Container Registry (e.g. gcr.io/myproject/server:latest).
- `--container-ports` (list of numbers) - Container ports to receive http requests at. Must be a number between 1 and 65535, inclusive.
- `--container-predict-route` (string) - HTTP path to send prediction requests to inside the container.
- `--container-shared-memory-size-mb` (number) - The amount of the VM memory to reserve as the shared memory for the model in megabytes.
- `--container-startup-probe-exec` (list of strings) - Exec specifies the action to take. Used by startup probe. An example of this argument would be ["cat", "/tmp/healthy"].
- `--container-startup-probe-period-seconds` (number) - How often (in seconds) to perform the startup probe. Default to 10 seconds. Minimum value is 1.
- `--container-startup-probe-timeout-seconds` (number) - Number of seconds after which the startup probe times out. Defaults to 1 second. Minimum value is 1.
- `--disable-dedicated-endpoint` (boolean) - If true, the dedicated endpoint will be disabled and the deployed model will be exposed through the shared DNS.
- `--enable-fast-tryout` (boolean) - If True, model will be deployed using faster deployment path. Useful for quick experiments. Not for production workloads. Only available for most popular models with certain machine types.
- `--endpoint-display-name` (string) - Display name of the endpoint with the deployed model.
- `--hugging-face-access-token` (string) - The access token from Hugging Face needed to read the model artifacts of gated models. It is only needed when the Hugging Face model to deploy is gated.
- `--machine-type` (string) - The machine type to deploy the model to. It should be a supported machine type from the deployment configurations of the model. Use `gcloud ai model-garden models list-deployment-config` to check the supported machine types.
- `--region` (string) - ID of the region or fully qualified identifier for the region.
- `--reservation-affinity` (object) - A ReservationAffinity can be used to configure a Vertex AI resource (e.g., a DeployedModel) to draw its Compute Engine resources from a Shared Reservation, or exclusively from on-demand capacity. Structure: `key`=`KEY`, `reservation-affinity-type`=`RESERVATION-AFFINITY-TYPE`, `values`=`VALUES`.
- `--spot` (boolean) - If true, schedule the deployment workload on Spot VM.
- `--use-dedicated-endpoint` (boolean) - If true, the endpoint will be exposed through a dedicated DNS. Your request to the dedicated endpoint will be isolated from other users' traffic and will have better performance and reliability.

### Request Example
```json
{
  "containerImage": "gcr.io/myproject/server:latest",
  "containerPorts": [8080],
  "containerPredictRoute": "/predict",
  "containerSharedMemorySizeMb": 1024,
  "containerStartupProbeExec": ["cat", "/tmp/healthy"],
  "containerStartupProbePeriodSeconds": 10,
  "containerStartupProbeTimeoutSeconds": 1,
  "disableDedicatedEndpoint": false,
  "enableFastTryout": false,
  "endpointDisplayName": "my-model-endpoint",
  "huggingFaceAccessToken": "hf_token",
  "machineType": "n1-standard-4",
  "region": "us-central1",
  "reservationAffinity": {
    "key": "my-reservation",
    "reservationAffinityType": "SPECIFIC_RESERVATION",
    "values": ["reservation-id-1"]
  },
  "spot": false,
  "useDedicatedEndpoint": true
}
```

### Response
#### Success Response (200)
- `id` (string) - The unique identifier for the deployed model.
- `displayName` (string) - The display name of the deployed model.
- `createTime` (string) - The timestamp when the model was created.

#### Response Example
```json
{
  "id": "1234567890",
  "displayName": "my-model-endpoint",
  "createTime": "2023-10-27T10:00:00Z"
}
```
```

--------------------------------

### gcloud access-context-manager policies describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Show details about a specific access policy.

```APIDOC
## gcloud access-context-manager policies describe

### Description
Show details about an access policy.

### Method
`gcloud access-context-manager policies describe`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies describe POLICY_NAME
```

### Response
#### Success Response (200)
Details of the access policy, including its name, parent, and etag.

#### Response Example
```json
{
  "name": "accessPolicies/12345",
  "parent": "organizations/67890",
  "etag": "etag123"
}
```
```

--------------------------------

### Create an access policy with a specific format

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and specifies the output format. The `--format` flag allows you to control how the command's output is presented, such as JSON or YAML.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Formatted Policy" --format=json
```

--------------------------------

### Create an access policy with user output enabled

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and ensures that user output is enabled. The `--user-output-enabled` flag controls whether user-facing output is displayed.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My User Output Policy" --user-output-enabled=true
```

--------------------------------

### Alpha version of describe command

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/describe

This is an alternative command for describing a Managed Microsoft AD domain using the alpha version of the gcloud CLI.

```bash
gcloud alpha active-directory domains describe
```

--------------------------------

### Create an access policy with a specific account

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy using a specified account. The `--account` flag allows you to authenticate with a particular Google Cloud account.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Account Policy" --account=user@example.com
```

--------------------------------

### Create an access policy with custom scopes

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command shows how to create an access policy with custom scopes, which can include folders and projects. The `--scopes` flag accepts a comma-separated list of scopes.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --scopes="folders/345,projects/567" --title="My Custom Scopes Policy"
```

--------------------------------

### List Active Directory Peerings (Beta)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/peerings/list

This command lists Active Directory peerings using the beta version of the API. Beta features are more stable than alpha but may still evolve.

```bash
gcloud beta active-directory peerings list
```

--------------------------------

### gcloud alpha ai models list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/list

This is an alpha version of the command. Use with caution as it may change or be removed.

```bash
gcloud alpha ai models list
```

--------------------------------

### Create an access policy with alpha version

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy using the alpha version of the gcloud access-context-manager component. Alpha versions may include experimental features and are subject to change.

```bash
gcloud alpha access-context-manager policies create --organization=organizations/123 --title="My Alpha Policy"
```

--------------------------------

### Deploy a Hugging Face model

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/model-garden/models/deploy

Deploy a Hugging Face model by providing its identifier and an access token. This command is suitable for models hosted on Hugging Face.

```bash
gcloud ai model-garden models deploy --model=meta-llama/Meta-Llama-3-8B --hugging-face-access-token={hf_token} --project=example --region=us-central1
```

--------------------------------

### gcloud alpha ai custom-jobs describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/custom-jobs/describe

This is an alpha version of the command to describe a custom job. Use with caution as features may change.

```bash
gcloud alpha ai custom-jobs describe
```

--------------------------------

### Configure SSL mode

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Specify the SSL mode for instance connections to the database. Default SSL mode matches the primary instance. Options include ALLOW_UNENCRYPTED_AND_ENCRYPTED and ENCRYPTED_ONLY.

```bash
--ssl-mode=`SSL_MODE`
```

--------------------------------

### Access Beta Version of Supported Services

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/supported-services

This command accesses the beta version of the supported-services command group. Beta features are more stable than alpha but may still evolve.

```bash
gcloud beta access-context-manager supported-services
```

--------------------------------

### gcloud access-context-manager policies create

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Create a new access policy.

```APIDOC
## gcloud access-context-manager policies create

### Description
Create a new access policy.

### Method
`gcloud access-context-manager policies create`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies create --organization=ORGANIZATION_ID
```

### Response
None explicitly defined for this command, success is indicated by exit code.
```

--------------------------------

### Create an access policy with verbose logging

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and enables verbose logging. The `--verbosity` flag can be set to different levels (e.g., debug, info, warning, error) to control the amount of output.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Verbose Policy" --verbosity=debug
```

--------------------------------

### List Beta AI Platform Jobs

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/jobs/list

This command lists jobs available in the beta version of AI Platform. Ensure you are using the correct gcloud components for beta releases.

```bash
gcloud beta ai-platform jobs list
```

--------------------------------

### Copy a model as a new version

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

Use this command to add a new version of an existing model. Specify the parent model resource name to append the copied model as a new version.

```bash
gcloud ai models copy --source-model=SOURCE_MODEL --destination-parent-model=DESTINATION_PARENT_MODEL
```

--------------------------------

### Create an access policy with a specific project

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and specifies the project to use for the operation. The `--project` flag sets the default project for the gcloud command.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Project Specific Policy" --project=my-gcp-project
```

--------------------------------

### Create an access policy scoped to a project

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

Use this command to create an access policy that applies only to a specific project. This limits the scope of service perimeters defined by this policy to the specified project. Ensure the project number is correct.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --scopes=projects/567 --title="My Project Policy"
```

--------------------------------

### Create a new secondary AlloyDB instance

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Use this command to create a new secondary instance for your AlloyDB cluster. Ensure you specify the instance name, cluster ID, and region.

```bash
gcloud alloydb instances create-secondary my-instance --cluster=my-cluster --region=us-central1
```

--------------------------------

### Create an access policy with impersonation

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy while impersonating a service account. This is useful for granting specific permissions to a service account to perform this action.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Impersonated Policy" --impersonate-service-account=my-sa@my-project.iam.gserviceaccount.com
```

--------------------------------

### Alpha version of gcloud ai models copy

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

This command is an alpha version for copying AI models. Use with caution as features may change.

```bash
gcloud alpha ai models copy
```

--------------------------------

### gcloud beta alloydb clusters import

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/clusters/import

This is a beta version of the command for importing data into an AlloyDB cluster. It offers more stability than alpha but may still undergo changes.

```bash
gcloud beta alloydb clusters import
```

--------------------------------

### List models in a specific project and region

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/list

Use this command to list all AI models associated with a particular Google Cloud project and region. Ensure you have the correct project ID and region specified.

```bash
gcloud ai models list --project=example --region=us-central1
```

--------------------------------

### Create an access policy scoped to a folder

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy that is restricted to a specific folder. Only projects within this folder can be added to service perimeters defined by this policy. The folder ID must be valid and exist within the specified organization.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --scopes=folders/345 --title="My Folder Policy"
```

--------------------------------

### Copy a model between regions

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

Use this command to copy a model from a source project and region to a destination region. Ensure the source model exists and specify both source and destination regions.

```bash
gcloud ai models copy --source-model=projects/example/locations/us-central1/models/123 --region=projects/example/locations/europe-west4
```

--------------------------------

### List Cloud Access Bindings

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/cloud-bindings/list

Lists all cloud access bindings under the specified organization. You can filter, limit, and sort the results.

```APIDOC
## GET /v1/organizations/{parent}/gcpUserAccessBindings

### Description
Lists cloud access bindings under a specified organization.

### Method
GET

### Endpoint
`https://accesscontextmanager.googleapis.com/v1/organizations/{parent}/gcpUserAccessBindings`

### Parameters
#### Path Parameters
- **parent** (string) - Required - The organization to list bindings for. Example: `organizations/12345`.

#### Query Parameters
- **filter** (string) - Optional - An expression to filter the list of bindings. For example, `name.startsWith('organizations/12345/gcpUserAccessBindings/abc')`.
- **pageSize** (integer) - Optional - The maximum number of bindings to return per page.
- **pageToken** (string) - Optional - The page token to retrieve the next page of results.
- **sortBy** (string) - Optional - The field to sort the results by. Example: `name` or `~name` for descending order.

### Response
#### Success Response (200)
- **gcpUserAccessBindings** (array) - A list of gcpUserAccessBindings.
  - **accessLevels** (array) - List of access level resource names.
  - **dryRunAccessLevels** (array) - List of dry run access level resource names.
  - **groupKey** (string) - The email address of the group.
  - **name** (string) - The resource name of the binding.
  - **sessionSettings** (object) - Settings for the session.
    - **sessionLength** (string) - The duration of the session.
    - **sessionLengthEnabled** (boolean) - Whether session length is enabled.
    - **sessionReauthMethod** (string) - The reauthentication method for the session.
  - **scopedAccessSettings** (object) - Settings for scoped access.
    - **activeSettings** (object) - The active access settings.
      - **accessLevels** (array) - List of access level resource names.
      - **sessionSettings** (object) - Settings for the session.
    - **dryRunSettings** (object) - The dry run access settings.
      - **accessLevels** (array) - List of access level resource names.

#### Response Example
```json
{
  "gcpUserAccessBindings": [
    {
      "accessLevels": [
        "accessPolicies/9522/accessLevels/device_trusted"
      ],
      "dryRunAccessLevels": [
        "accessPolicies/9522/accessLevels/specific_location"
      ],
      "groupKey": "a3dad",
      "name": "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N",
      "sessionSettings": {
        "sessionLength": "57600s",
        "sessionLengthEnabled": true,
        "sessionReauthMethod": "LOGIN"
      }
    }
  ]
}
```
```

--------------------------------

### gcloud ai model-monitoring-jobs Commands

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/model-monitoring-jobs

Overview of available commands for managing Vertex AI model monitoring jobs.

```APIDOC
## gcloud ai model-monitoring-jobs

### Description
Manage Vertex AI model monitoring jobs.

### Commands
- **create**: Create a new Vertex AI model monitoring job.
- **delete**: Delete an existing Vertex AI model deployment monitoring job.
- **describe**: Get detailed model deployment monitoring job information about the given job id.
- **list**: List the model deployment monitoring jobs of the given project and region.
- **pause**: Pause a running Vertex AI model deployment monitoring job.
- **resume**: Resume a paused Vertex AI model deployment monitoring job.
- **update**: Update an Vertex AI model deployment monitoring job.
```

--------------------------------

### List AlloyDB Users (Alpha)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/list

This command is part of the alpha release for managing AlloyDB users. Use with caution as features may change.

```bash
gcloud alpha alloydb users list
```

--------------------------------

### Create an access policy with flattened output

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy and flattens the output. The `--flatten` flag is useful for simplifying complex nested output structures, making it easier to parse.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Flattened Policy" --flatten=field
```

--------------------------------

### Access Approval request approval variants

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval/requests/approve

Alternative command variants for alpha and beta releases.

```bash
gcloud alpha access-approval requests approve
```

```bash
gcloud beta access-approval requests approve
```

--------------------------------

### List Alpha AI Platform Jobs

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/jobs/list

This command lists jobs available in the alpha version of AI Platform. Ensure you are using the correct gcloud components for alpha releases.

```bash
gcloud alpha ai-platform jobs list
```

--------------------------------

### gcloud ai model-garden models deploy

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/model-garden/models/deploy

Deploys a model from Model Garden to a Vertex AI endpoint. This command supports deploying models from Model Garden, Hugging Face, and custom weights stored in GCS. It allows for detailed configuration of the deployment, including hardware specifications, container settings, and health probes.

```APIDOC
## POST /v1/projects/{projectId}/locations/{locationId}/endpoints/{endpointId}/deployedModels

### Description
Deploys a model from Model Garden to a Vertex AI endpoint.

### Method
POST

### Endpoint
`/v1/projects/{projectId}/locations/{locationId}/endpoints/{endpointId}/deployedModels`

### Parameters
#### Path Parameters
- **projectId** (string) - Required - The Google Cloud project ID.
- **locationId** (string) - Required - The region where the Vertex AI endpoint is located.
- **endpointId** (string) - Required - The ID of the Vertex AI endpoint.

#### Query Parameters
- **--model** (string) - Required - The model to be deployed. Format: `{publisher_name}/{model_name}@{model_version_name}` for Model Garden models, `{model_name}` for Hugging Face models, or `gs://{gcs_bucket_uri}` for custom weights.
- **--accelerator-count** (integer) - Optional - The number of accelerators to use for serving the model. Must be non-negative.
- **--accelerator-type** (string) - Optional - The type of accelerator to use. Must be a supported type for the model.
- **--accept-eula** (boolean) - Optional - If set, the user accepts the End User License Agreement (EULA) of the model.
- **--asynchronous** (boolean) - Optional - If set to true, the command terminates immediately without polling the operation status.
- **--container-args** (list of strings) - Optional - Comma-separated arguments passed to the container image's command.
- **--container-command** (list of strings) - Optional - Entrypoint for the container image.
- **--container-deployment-timeout-seconds** (integer) - Optional - Deployment timeout in seconds.
- **--container-env-vars** (list of key-value pairs) - Optional - Environment variables to set in the container (e.g., `KEY=VALUE`).
- **--container-grpc-ports** (list of integers) - Optional - Container ports for gRPC requests (1-65535).
- **--container-health-probe-exec** (list of strings) - Optional - Exec action for health probe (e.g., `["cat", "/tmp/healthy"]`).
- **--container-health-probe-period-seconds** (integer) - Optional - How often to perform the health probe (default: 10 seconds, min: 1).
- **--container-health-probe-timeout-seconds** (integer) - Optional - Timeout for health probe in seconds (default: 1 second, min: 1).
- **--container-health-route** (string) - Optional - HTTP path for health checks within the container.
- **--container-image-uri** (string) - Optional - The URI of the container image.
- **--container-ports** (list of integers) - Optional - Container ports to receive requests.
- **--container-predict-route** (string) - Optional - HTTP path for prediction requests within the container.
- **--container-shared-memory-size-mb** (integer) - Optional - Shared memory size in MB for the container.
- **--container-startup-probe-exec** (list of strings) - Optional - Exec action for startup probe.
- **--container-startup-probe-period-seconds** (integer) - Optional - How often to perform the startup probe.
- **--container-startup-probe-timeout-seconds** (integer) - Optional - Timeout for startup probe in seconds.
- **--disable-dedicated-endpoint** (boolean) - Optional - Disables the use of a dedicated endpoint.
- **--enable-fast-tryout** (boolean) - Optional - Enables fast tryout mode.
- **--endpoint-display-name** (string) - Optional - Display name for the endpoint.
- **--hugging-face-access-token** (string) - Optional - Access token for Hugging Face models.
- **--machine-type** (string) - Optional - The machine type to use for the deployment.
- **--region** (string) - Optional - The region for the deployment (if not specified in the endpoint).
- **--reservation-affinity** (object) - Optional - Reservation affinity configuration.
- **--spot** (boolean) - Optional - Use spot instances for the deployment.
- **--use-dedicated-endpoint** (boolean) - Optional - Uses a dedicated endpoint for the deployment.

### Request Example
```json
{
  "model": "google/gemma2@gemma-2-9b",
  "project": "example",
  "region": "us-central1"
}
```

### Response
#### Success Response (200)
- **operation** (object) - Details of the long-running operation for deployment.

#### Response Example
```json
{
  "operation": {
    "name": "projects/example/locations/us-central1/operations/1234567890",
    "metadata": {
      "@type": "type.googleapis.com/google.cloud.aiplatform.v1.DeploymentModelOperationMetadata"
    },
    "done": false
  }
}
```
```

--------------------------------

### gcloud access-context-manager policies list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

List all access policies within an organization.

```APIDOC
## gcloud access-context-manager policies list

### Description
List access policies.

### Method
`gcloud access-context-manager policies list`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies list --organization=ORGANIZATION_ID
```

### Response
#### Success Response (200)
A list of access policies, each with its name, parent, and etag.

#### Response Example
```json
[
  {
    "name": "accessPolicies/12345",
    "parent": "organizations/67890",
    "etag": "etag123"
  },
  {
    "name": "accessPolicies/67890",
    "parent": "organizations/67890",
    "etag": "etag456"
  }
]
```
```

--------------------------------

### Describe a Managed Microsoft AD domain

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/describe

Use this command to view metadata for a specific Managed Microsoft AD domain. Ensure the domain name is accurate and your account has the necessary permissions.

```bash
gcloud active-directory domains describe my-domain.com
```

--------------------------------

### gcloud wide flags

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Global flags available for all gcloud commands, including --access-token-file, --account, --billing-project, and others. Run '$ gcloud help' for details.

```bash
--access-token-file
     --account
     --billing-project
     --configuration
     --flags-file
     --flatten
     --format
     --help
     --impersonate-service-account
     --log-http
     --project
     --quiet
     --trace-token
     --user-output-enabled
     --verbosity
```

--------------------------------

### gcloud active-directory domains describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/describe

Describes a Managed Microsoft AD domain, showing its metadata. This command requires a domain name and can fail if the domain does not exist or if the account lacks permissions.

```APIDOC
## gcloud active-directory domains describe

### Description
Show metadata for a Managed Microsoft AD domain. Displays all metadata associated with an Active Directory domain given a valid AD domain fully-qualified domain name.

This command can fail for the following reasons:
* The domain specified does not exist.
* The active account does not have permission to access the given domain.

### Method
GET

### Endpoint
`gcloud active-directory domains describe DOMAIN [GCLOUD_WIDE_FLAG …]`

### Parameters
#### Path Parameters
- **DOMAIN** (string) - Required - ID of the domain or fully qualified identifier for the domain. This represents a Cloud resource.

#### Query Parameters
None explicitly listed, but GCLOUD_WIDE_FLAGs apply.

#### Request Body
None

### Request Example
```bash
gcloud active-directory domains describe my-domain.com
```

### Response
#### Success Response (200)
Metadata for the specified Managed Microsoft AD domain.

#### Response Example
```json
{
  "name": "projects/PROJECT_ID/locations/global/domains/DOMAIN_ID",
  "displayName": "my-domain.com",
  "fqdn": "my-domain.com",
  "reservedIpRange": "10.0.0.0/24",
  "state": "READY",
  "createTime": "2023-01-01T10:00:00Z",
  "lastModifiedTime": "2023-01-01T10:00:00Z"
}
```
```

--------------------------------

### Connection pooling min pool size

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The minimum pool size for managed connection pooling.

```bash
--connection-pooling-min-pool-size=`CONNECTION_POOLING_MIN_POOL_SIZE`
```

--------------------------------

### gcloud access-approval requests commands

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval/requests

Overview of the available commands for managing Access Approval requests.

```APIDOC
## gcloud access-approval requests

### Description
Manage Access Approval requests created by Google personnel for administrative access to resources.

### Commands
- **approve**: Approve an Access Approval request.
- **dismiss**: Dismiss an Access Approval request.
- **get**: Get an Access Approval request.
- **invalidate**: Invalidate an Access Approval request.
- **list**: List Access Approval requests.
```

--------------------------------

### gcloud alloydb instances describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/describe

Describes an AlloyDB instance within a given cluster.

```APIDOC
## gcloud alloydb instances describe

### Description
Describes an AlloyDB instance within a given cluster.

### Method
GET

### Endpoint
`gcloud alloydb instances describe`

### Parameters
#### Path Parameters
- **INSTANCE** (string) - Required - AlloyDB instance ID

#### Query Parameters
- **cluster** (string) - Required - AlloyDB cluster ID
- **region** (string) - Required - Regional location (e.g. `asia-east1`, `us-east1`). See the full list of regions at https://cloud.google.com/sql/docs/instance-locations.
- **view** (string) - Optional - View of the instance to return. `VIEW` must be one of: `basic`, `full`.

### Request Example
```bash
gcloud alloydb instances describe my-instance --cluster=my-cluster --region=us-central1 --view=BASIC/FULL
```

### Response
#### Success Response (200)
- **instance** (object) - Details of the AlloyDB instance.
- **name** (string) - The name of the instance.
- **state** (string) - The current state of the instance.
- **createTime** (string) - The timestamp when the instance was created.
- **instanceType** (string) - The type of the instance.
- **ipAddress** (string) - The IP address of the instance.
- **region** (string) - The region where the instance is located.
- **cluster** (string) - The ID of the cluster the instance belongs to.
- **databaseVersion** (string) - The database version of the instance.
- **nodeCount** (integer) - The number of nodes in the instance.
- **cpu** (string) - The CPU configuration of the instance.
- **memory** (string) - The memory configuration of the instance.
- **diskSize** (string) - The disk size of the instance.

#### Response Example
```json
{
  "instance": {
    "name": "projects/my-project/instances/my-instance",
    "state": "READY",
    "createTime": "2023-01-01T10:00:00Z",
    "instanceType": "PRIMARY",
    "ipAddress": "10.0.0.1",
    "region": "us-central1",
    "cluster": "projects/my-project/clusters/my-cluster",
    "databaseVersion": "POSTGRES_14",
    "nodeCount": 2,
    "cpu": "4 vCPU",
    "memory": "16GiB",
    "diskSize": "100GiB"
  }
}
```
```

--------------------------------

### List VPC Service Controls Supported Services

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/supported-services

This command lists all services that are supported by VPC Service Controls.

```APIDOC
## gcloud access-context-manager supported-services list

### Description
Lists all VPC Service Controls supported services.

### Method
GET

### Endpoint
gcloud access-context-manager supported-services list

### Parameters
This command does not have any specific parameters beyond the global flags.

### Request Example
```
gcloud access-context-manager supported-services list
```

### Response
#### Success Response (200)
- **services** (array) - A list of supported services and their properties.

#### Response Example
```json
{
  "services": [
    {
      "name": "compute.googleapis.com",
      "title": "Compute Engine API"
    },
    {
      "name": "storage.googleapis.com",
      "title": "Cloud Storage API"
    }
  ]
}
```
```

--------------------------------

### Import data into an AlloyDB cluster

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/clusters/import

Use this command to import data into an AlloyDB cluster from a Google Cloud Storage file. Specify the cluster, region, database, and the GCS URI of the source file. You can choose between SQL or CSV import formats.

```bash
gcloud alloydb clusters import my-cluster --region=us-central1 --database=my-database --gcs-uri=gs://my-bucket/source-file-path --sql --user=my-user
```

--------------------------------

### gcloud beta alloydb instances create-secondary variant

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Command variant for creating a secondary AlloyDB instance using the beta release channel.

```bash
gcloud beta alloydb instances create-secondary
```

--------------------------------

### Describe a VPC Service Controls Supported Service

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/supported-services

This command retrieves detailed information about a specific VPC Service Controls supported service.

```APIDOC
## gcloud access-context-manager supported-services describe SERVICE_NAME

### Description
Gets information about a specific VPC Service Controls Supported Service.

### Method
GET

### Endpoint
gcloud access-context-manager supported-services describe SERVICE_NAME

### Parameters
#### Path Parameters
- **SERVICE_NAME** (string) - Required - The name of the service to describe (e.g., "compute.googleapis.com").

### Request Example
```
gcloud access-context-manager supported-services describe compute.googleapis.com
```

### Response
#### Success Response (200)
- **name** (string) - The unique identifier of the service.
- **title** (string) - The human-readable title of the service.

#### Response Example
```json
{
  "name": "compute.googleapis.com",
  "title": "Compute Engine API"
}
```
```

--------------------------------

### gcloud ai-platform operations describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/operations/describe

Describes an AI Platform operation by its name, with an optional region parameter.

```APIDOC
## gcloud ai-platform operations describe

### Description
Describe an AI Platform operation.

### Method
CLI Command

### Endpoint
gcloud ai-platform operations describe

### Parameters
#### Positional Arguments
- **OPERATION** (string) - Required - Name of the operation.

#### Flags
- **--region** (string) - Optional - Google Cloud region of the regional endpoint to use for this command. If unspecified, the command uses the global endpoint of the AI Platform Training and Prediction API.
```

--------------------------------

### Copy a model with KMS encryption

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

This command copies a model and encrypts it using a specified customer-managed encryption key (KMS). The KMS key must reside in the same region as the destination model.

```bash
gcloud ai models copy --source-model=SOURCE_MODEL --kms-key-name=KMS_KEY_NAME --region=REGION --destination-model-id=DESTINATION_MODEL_ID
```

--------------------------------

### Replace All Service Perimeters

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

Use the `replace-all` command to replace all existing service perimeters with a new configuration.

```APIDOC
## POST /api/access-context-manager/v1/perimeters:replaceAll

### Description
Replaces all existing service perimeters with a new configuration.

### Method
POST

### Endpoint
`/api/access-context-manager/v1/perimeters:replaceAll`

### Parameters
#### Query Parameters
- **parent** (string) - Required - The name of the parent resource (e.g., `organizations/123`).

#### Request Body
- **perimeters** (array of objects) - Required - A list of service perimeters to replace the existing ones with.
  - **name** (string) - Required - The resource name of the Service Perimeter.
  - **title** (string) - Optional - A human-readable title for the Service Perimeter.
  - **resources** (array of strings) - Optional - A list of Google Cloud resource names that are part of this Service Perimeter.
  - **restrictedServices** (array of strings) - Optional - A list of Google Cloud services that are restricted from being accessed from outside the perimeter.
  - **ingressPolicies** (array of objects) - Optional - Defines the conditions for traffic ingress into the perimeter.
  - **egressPolicies** (array of objects) - Optional - Defines the conditions for traffic egress from the perimeter.
- **updateMask** (string) - Optional - Field mask to determine which fields to update.

### Request Example
```json
{
  "perimeters": [
    {
      "name": "organizations/123/locations/global/servicePerimeters/myPerimeter1",
      "title": "My Perimeter 1",
      "resources": ["projects/12345"]
    }
  ]
}
```

### Response
#### Success Response (200)
- **name** (string) - The resource name of the Service Perimeter.
- **title** (string) - The human-readable title of the Service Perimeter.
- **resources** (array of strings) - The list of Google Cloud resources included in the perimeter.
- **restrictedServices** (array of strings) - The list of restricted services.
- **ingressPolicies** (array of objects) - The ingress policies.
- **egressPolicies** (array of objects) - The egress policies.

#### Response Example
```json
{
  "name": "organizations/123/locations/global/servicePerimeters/myPerimeter1",
  "title": "My Perimeter 1",
  "resources": ["projects/12345"],
  "restrictedServices": [],
  "ingressPolicies": [],
  "egressPolicies": []
}
```
```

--------------------------------

### Access Alpha Version of Supported Services

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/supported-services

This command accesses the alpha version of the supported-services command group. Use with caution as alpha features may change.

```bash
gcloud alpha access-context-manager supported-services
```

--------------------------------

### List Active Directory Peerings (Alpha)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/peerings/list

This command lists Active Directory peerings using the alpha version of the API. Use with caution as alpha features may change.

```bash
gcloud alpha active-directory peerings list
```

--------------------------------

### List Vertex AI Endpoints

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/endpoints/list

This command lists all existing Vertex AI endpoints in a specified project and region. You can optionally filter these endpoints.

```APIDOC
## GET / Gcloud Command

### Description
Lists existing Vertex AI endpoints.

### Method
Gcloud Command

### Endpoint
gcloud ai endpoints list

### Parameters
#### Query Parameters
- `--list-model-garden-endpoints-only` (boolean) - Optional - Whether to only list endpoints related to Model Garden.
- `--region` (string) - Optional - ID of the region or fully qualified identifier for the region.
- `--filter` (string) - Optional - Apply a Boolean filter EXPRESSION to each resource item to be listed.
- `--limit` (integer) - Optional - Maximum number of resources to list. The default is unlimited.
- `--page-size` (integer) - Optional - Maximum number of resources per page.
- `--sort-by` (list of strings) - Optional - Comma-separated list of resource field key names to sort by.
- `--uri` (boolean) - Optional - Print a list of resource URIs instead of the default output.

### Request Example
```
gcloud ai endpoints list --project=example --region=us-central1
```

### Response
#### Success Response (200)
- The response will be a list of Vertex AI endpoints matching the specified criteria.

#### Response Example
```json
{
  "example": "response body"
}
```
```

--------------------------------

### List Model Garden Endpoints Only

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/endpoints/list

This command specifically lists Vertex AI endpoints that are created from Model Garden in a specified project and region.

```APIDOC
## GET / Gcloud Command

### Description
Lists Vertex AI endpoints related to Model Garden.

### Method
Gcloud Command

### Endpoint
gcloud ai endpoints list --list-model-garden-endpoints-only

### Parameters
#### Query Parameters
- `--list-model-garden-endpoints-only` (boolean) - Required - Whether to only list endpoints related to Model Garden.
- `--region` (string) - Optional - ID of the region or fully qualified identifier for the region.
- `--project` (string) - Optional - The project to list endpoints from.

### Request Example
```
gcloud ai endpoints list --project=example --region=us-central1 --list-model-garden-endpoints-only
```

### Response
#### Success Response (200)
- The response will be a list of Vertex AI endpoints from Model Garden matching the specified criteria.

#### Response Example
```json
{
  "example": "response body"
}
```
```

--------------------------------

### Enforce connectors for connections

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Enable or disable enforcing connectors only (e.g., AuthProxy) connections to the database. Use --require-connectors to enable and --no-require-connectors to disable.

```bash
--[no-]require-connectors
```

--------------------------------

### Describe a Service Perimeter

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

Use the `describe` command to view the details of a specific service perimeter.

```APIDOC
## GET /api/access-context-manager/v1/perimeters/{name}

### Description
Shows details about a service perimeter.

### Method
GET

### Endpoint
`/api/access-context-manager/v1/perimeters/{name}`

### Parameters
#### Path Parameters
- **name** (string) - Required - The resource name of the Service Perimeter to describe. Example: `organizations/123/locations/global/servicePerimeters/myPerimeter`.

### Response
#### Success Response (200)
- **name** (string) - The resource name of the Service Perimeter.
- **title** (string) - The human-readable title of the Service Perimeter.
- **resources** (array of strings) - The list of Google Cloud resources included in the perimeter.
- **restrictedServices** (array of strings) - The list of restricted services.
- **ingressPolicies** (array of objects) - The ingress policies.
- **egressPolicies** (array of objects) - The egress policies.

#### Response Example
```json
{
  "name": "organizations/123/locations/global/servicePerimeters/myPerimeter",
  "title": "My Perimeter",
  "resources": ["projects/12345"],
  "restrictedServices": [],
  "ingressPolicies": [],
  "egressPolicies": []
}
```
```

--------------------------------

### Configure outbound public IP

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Add outbound Public IP connectivity to an AlloyDB instance. Use --outbound-public-ip to enable and --no-outbound-public-ip to disable.

```bash
--[no-]outbound-public-ip
```

--------------------------------

### gcloud ai-platform jobs list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/jobs/list

Lists existing AI Platform jobs. This command allows you to view and manage your AI Platform jobs.

```APIDOC
## gcloud ai-platform jobs list

### Description
List existing AI Platform jobs.

### Method
GET (implied by list operation)

### Endpoint
`/v1/projects/{PROJECT_ID}/jobs` (conceptual endpoint for listing jobs)

### Parameters
#### Query Parameters
- **--filter** (`EXPRESSION`) - Optional - Apply a Boolean filter `EXPRESSION` to each resource item to be listed. For more details and examples of filter expressions, run $ gcloud topic filters.
- **--limit** (`LIMIT`) - Optional - Maximum number of resources to list. The default is `unlimited`.
- **--page-size** (`PAGE_SIZE`) - Optional - Specifies the maximum number of resources per page. The default is determined by the service if it supports paging, otherwise it is `unlimited`.
- **--sort-by** (`FIELD`,...) - Optional - Comma-separated list of resource field key names to sort by. Prefix a field with ``~´´ for descending order on that field.
- **--uri** - Optional - Print a list of resource URIs instead of the default output.

### Request Example
```bash
gcloud ai-platform jobs list
```

### Response
#### Success Response (200)
- **jobs** (array) - A list of AI Platform jobs.
  - **name** (string) - The name of the job.
  - **state** (string) - The current state of the job.
  - **createTime** (string) - The timestamp when the job was created.
  - **endTime** (string) - The timestamp when the job ended.

#### Response Example
```json
{
  "jobs": [
    {
      "name": "projects/your-project/jobs/your-job-1",
      "state": "SUCCEEDED",
      "createTime": "2023-01-01T10:00:00Z",
      "endTime": "2023-01-01T11:00:00Z"
    },
    {
      "name": "projects/your-project/jobs/your-job-2",
      "state": "RUNNING",
      "createTime": "2023-01-02T12:00:00Z"
    }
  ]
}
```
```

--------------------------------

### List Endpoints in a Specific Region

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/endpoints/list

Use this command to list all Vertex AI endpoints within a specified project and region. Ensure you have the necessary permissions to access Vertex AI resources.

```bash
gcloud ai endpoints list --project=example --region=us-central1
```

--------------------------------

### Connection pooling stats users

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Comma-separated list of database users to access connection pooling stats.

```bash
--connection-pooling-stats-users=[`STATS_USERS`,...]
```

--------------------------------

### gcloud ai tensorboards describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/tensorboards/describe

Retrieves detailed information about a specific Tensorboard instance using its ID and region.

```APIDOC
## GET /v1/projects/{projectId}/locations/{locationId}/tensorboards/{tensorboardId}

### Description
Gets detailed Tensorboard information about the given Tensorboard id.

### Method
GET

### Endpoint
`gcloud ai tensorboards describe`

### Parameters
#### Path Parameters
- **TENSORBOARD** (string) - Required - ID of the tensorboard or fully qualified identifier for the tensorboard.
- **--region** (string) - Required - Cloud region for the tensorboard.

#### Query Parameters
- **--project** (string) - Optional - The Google Cloud project ID to use for this command.

### Request Example
```bash
gcloud ai tensorboards describe projects/my-project/locations/us-central1/tensorboards/12345
```

### Response
#### Success Response (200)
- **name** (string) - The resource name of the Tensorboard.
- **displayName** (string) - The user specified name of the Tensorboard.
- **description** (string) - The description of the Tensorboard.
- **createTime** (string) - The timestamp of when the Tensorboard was created.
- **updateTime** (string) - The timestamp of when the Tensorboard was last updated.
- **labels** (object) - The labels with user-defined metadata to organize your Tensorboards.

#### Response Example
```json
{
  "name": "projects/my-project/locations/us-central1/tensorboards/12345",
  "displayName": "my-tensorboard",
  "description": "This is my tensorboard.",
  "createTime": "2023-01-01T10:00:00Z",
  "updateTime": "2023-01-01T10:00:00Z",
  "labels": {
    "env": "production"
  }
}
```
```

--------------------------------

### gcloud access-approval settings

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval

Manage Access Approval settings.

```APIDOC
## gcloud access-approval settings

### Description
Manage Access Approval settings.

### Synopsis
`gcloud access-approval settings` GROUP [`GCLOUD_WIDE_FLAG …`]

### Groups
``GROUP`` is one of the following:

`describe`
    Describes the Access Approval settings for a project.

`update`
    Updates the Access Approval settings for a project.
```

--------------------------------

### gcloud access-approval Overview

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval

The gcloud access-approval command group provides subcommands for managing Access Approval.

```APIDOC
## gcloud access-approval

### Description
Manages Access Approval requests and settings. Access Approval enables customers to require explicit approval whenever Google support and engineering needs to access customer data.

### Synopsis
`gcloud access-approval` GROUP [GCLOUD_WIDE_FLAG …]

### Groups
``GROUP`` is one of the following:

`requests`
    Manage Access Approval requests.

`service-account`
    Manage Access Approval service account.

`settings`
    Manage Access Approval settings.

### Gcloud Wide Flags
These flags are available to all commands: `--help`.
Run `$ gcloud help` for details.
```

--------------------------------

### Create an access policy with quiet mode

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

This command creates an access policy in quiet mode, suppressing most output. The `--quiet` flag is useful for scripting when you only want to see essential information or errors.

```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Quiet Policy" --quiet
```

--------------------------------

### gcloud alpha alloydb clusters import

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/clusters/import

This is an alpha version of the command for importing data into an AlloyDB cluster. Use with caution as features may change.

```bash
gcloud alpha alloydb clusters import
```

--------------------------------

### List Service Perimeters

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

Use the `list` command to retrieve a list of all service perimeters within an organization.

```APIDOC
## GET /api/access-context-manager/v1/perimeters

### Description
Lists all service perimeters within an organization.

### Method
GET

### Endpoint
`/api/access-context-manager/v1/perimeters`

### Parameters
#### Query Parameters
- **parent** (string) - Required - The name of the parent resource (e.g., `organizations/123`).

### Response
#### Success Response (200)
- **perimeters** (array of objects) - A list of service perimeters.
  - **name** (string) - The resource name of the Service Perimeter.
  - **title** (string) - The human-readable title of the Service Perimeter.
  - **resources** (array of strings) - The list of Google Cloud resources included in the perimeter.
  - **restrictedServices** (array of strings) - The list of restricted services.
  - **ingressPolicies** (array of objects) - The ingress policies.
  - **egressPolicies** (array of objects) - The egress policies.

#### Response Example
```json
{
  "perimeters": [
    {
      "name": "organizations/123/locations/global/servicePerimeters/myPerimeter1",
      "title": "My Perimeter 1",
      "resources": ["projects/12345"],
      "restrictedServices": [],
      "ingressPolicies": [],
      "egressPolicies": []
    },
    {
      "name": "organizations/123/locations/global/servicePerimeters/myPerimeter2",
      "title": "My Perimeter 2",
      "resources": ["projects/67890"],
      "restrictedServices": [],
      "ingressPolicies": [],
      "egressPolicies": []
    }
  ]
}
```
```

--------------------------------

### Connection pooling max client connections

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The maximum number of client connections for managed connection pooling.

```bash
--connection-pooling-max-client-connections=`CONNECTION_POOLING_MAX_CLIENT_CONNECTIONS`
```

--------------------------------

### List AlloyDB Users

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/list

Use this command to list all users associated with a specific AlloyDB cluster. Ensure you provide the cluster ID and the region where the cluster is located.

```bash
gcloud alloydb users list --cluster=my-cluster --region=us-central1
```

--------------------------------

### gcloud alpha alloydb instances create-secondary variant

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Command variant for creating a secondary AlloyDB instance using the alpha release channel.

```bash
gcloud alpha alloydb instances create-secondary
```

--------------------------------

### Connection pooling max prepared statements

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The maximum number of prepared statements allowed in the pool.

```bash
--connection-pooling-max-prepared-statements=`CONNECTION_POOLING_MAX_PREPARED_STATEMENTS`
```

--------------------------------

### gcloud alloydb instances create-secondary

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Creates a new AlloyDB SECONDARY instance within a given cluster. This command allows for detailed configuration of the secondary instance, including network settings, availability, and connection pooling.

```APIDOC
## POST /v1/projects/{project}/locations/{location}/clusters/{cluster}/instances

### Description
Creates a new AlloyDB SECONDARY instance within a given cluster. This command allows for detailed configuration of the secondary instance, including network settings, availability, and connection pooling.

### Method
POST

### Endpoint
`/v1/projects/{project}/locations/{location}/clusters/{cluster}/instances`

### Parameters
#### Path Parameters
* **project** (string) - Required - The project ID.
* **location** (string) - Required - The region of the cluster.
* **cluster** (string) - Required - The AlloyDB cluster ID.
* **instance** (string) - Required - The AlloyDB instance ID for the secondary instance.

#### Query Parameters
* **async** (boolean) - Optional - Return immediately, without waiting for the operation in progress to complete.

#### Request Body
* **instance** (object) - Required - The instance resource to create.
    * **name** (string) - Required - The ID of the instance.
    * **instanceType** (string) - Required - The type of the instance. Must be `SECONDARY`.
    * **availabilityType** (string) - Optional - Specifies level of availability. Must be one of: `REGIONAL`, `ZONAL`.
    * **ipAddressAllocation** (string) - Optional - Specifies the IP address allocation for the instance. Must be one of: `USE_IP_RANGE`, `USE_PUBLIC_IP`.
    * **allocatedIpRange** (string) - Optional - Name of the allocated IP range for the private IP AlloyDB instance. Required if `ipAddressAllocation` is `USE_IP_RANGE`.
    * **authorizedNetworks** (array) - Optional - List of authorized external networks to set on the instance. Each element should be a CIDR notation string (e.g., "1.2.3.4/30"). Only allowed if `ipAddressAllocation` is `USE_PUBLIC_IP`.
    * **publicIpEnabled** (boolean) - Optional - Whether to enable public IP on the instance. Defaults to false.
    * **privateNetwork** (string) - Optional - The Private Service Connect network attachment URI for the instance. Only applicable for PSC-enabled clusters.
    * **allowedPscProjects** (array) - Optional - Comma-separated list of allowed consumer projects to create endpoints for Private Service Connect (PSC) connectivity for the instance. Only instances in PSC-enabled clusters are allowed to set this field.
    * **connectionPoolConfig** (object) - Optional - Connection pool configuration for the instance.
        * ** 1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000年03月24日 10:00:00 GMT+00:00 2024-03-24T10:00:00Z
```

--------------------------------

### gcloud access-context-manager levels replace-all

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/levels/replace-all

This command replaces all existing access levels in a specified access policy with the access levels provided in a source file. It supports an optional etag for versioning.

```APIDOC
## gcloud access-context-manager levels replace-all

### Description
Replace all existing access levels in a specified access policy with access levels defined in a file.

### Method
POST (implied by the nature of replacing all resources)

### Endpoint
`gcloud access-context-manager levels replace-all`

### Parameters
#### Path Parameters
- **POLICY** (string) - Required - The access policy that contains the levels you want to replace. This represents a Cloud resource. ID of the policy or fully qualified identifier for the policy.

#### Query Parameters
None

#### Request Body
This command does not directly take a request body in the typical REST sense. The access levels are provided via the `--source-file` flag.

### Request Example
To replace all levels within a policy, using etag:
```
gcloud access-context-manager levels replace-all my-policy-number --source-file=path-to-file-containing-all-replacement-access-levels.yaml --etag=optional-latest-etag-of-policy
```

To replace all levels within a policy, without using etag:
```
gcloud access-context-manager levels replace-all my-policy-number --source-file=path-to-file-containing-all-replacement-access-levels.yaml
```

### Parameters Details
#### Required Flags
- **`--source-file`** (`SOURCE_FILE`) - Required - Path to a file containing a list of access levels. The file should be in YAML format and contain a list of access level objects.

#### Optional Flags
- **`--etag`** (`ETAG`) - Optional - An etag which specifies the version of the Access Policy. Only etags that represent the latest version of the Access Policy will be accepted.

### Response
#### Success Response (200)
- **(object)** - The response typically indicates the success of the operation. Specific fields depend on the API version and implementation, but may include details of the updated policy or access levels.

#### Response Example
(Response structure not explicitly defined in the provided text, but would typically be a JSON object confirming the update.)

### Notes
- This command uses the `accesscontextmanager/v1` API.
- Variants `gcloud alpha access-context-manager levels replace-all` and `gcloud beta access-context-manager levels replace-all` are also available.
```

--------------------------------

### gcloud alloydb clusters import

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/clusters/import

Import data into an AlloyDB cluster from Google Cloud Storage.

```APIDOC
## gcloud alloydb clusters import

### Description
Import data into an AlloyDB cluster from Google Cloud Storage.

### Method
`gcloud` command-line tool

### Endpoint
`gcloud alloydb clusters import`

### Parameters
#### Positional Arguments
- **CLUSTER** (string) - Required - AlloyDB cluster ID

#### Required Flags
- **--gcs-uri** (string) - Required - URI of the source file for import. This must be specified.
- **--region** (string) - Required - Regional location (e.g. `asia-east1`, `us-east1`). See the full list of regions at https://cloud.google.com/sql/docs/instance-locations.

#### Import Options (Exactly one of the following groups must be specified):

##### SQL Import Options
- **--sql** (boolean) - Specify source file type.

##### CSV Import Options
- **--csv** (boolean) - Specify source file type. This flag argument must be specified if any of the other arguments in this group are specified.
- **--table** (string) - Table name to which the data has to be imported. This flag argument must be specified if any of the other arguments in this group are specified.
- **--columns** (string) - Comma-separated list of column names to be used for import.
- **--escape-character** (string) - Escape character in the source file.
- **--field-delimiter** (string) - Field delimiter in the source file.
- **--quote-character** (string) - Quote character in the source file.

#### Optional Flags
- **--async** (boolean) - Return immediately, without waiting for the operation in progress to complete.
- **--database** (string) - Database name.
- **--user** (string) - Database user for the import.

### Request Example
```
gcloud alloydb clusters import my-cluster --region=us-central1 --database=my-database --gcs-uri=gs://my-bucket/source-file-path --sql --user=my-user
```

### Response
(No specific success response fields are detailed in the provided text, but the command implies a successful import operation or an asynchronous operation initiation.)

### Error Handling
(Error handling details are not explicitly provided in the source text, but standard gcloud error reporting would apply.)
```

--------------------------------

### gcloud ai models list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/list

Lists the AI models available in a specified project and region.

```APIDOC
## gcloud ai models list

### Description
Lists the AI models of the given project and region.

### Method
CLI Command

### Endpoint
gcloud ai models list

### Parameters
#### Query Parameters
- **--region** (string) - Optional - ID of the region or fully qualified identifier for the region.
- **--filter** (string) - Optional - Apply a Boolean filter EXPRESSION to each resource item to be listed.
- **--limit** (integer) - Optional - Maximum number of resources to list.
- **--page-size** (integer) - Optional - Maximum number of resources per page.
- **--sort-by** (list) - Optional - Comma-separated list of resource field key names to sort by.
- **--uri** (boolean) - Optional - Print a list of resource URIs instead of the default output.

### Request Example
gcloud ai models list --project=example --region=us-central1
```

--------------------------------

### gcloud alloydb users list

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/list

Lists AlloyDB users in a specified cluster. This command requires the cluster ID and region. Optional flags allow for filtering, limiting the number of results, setting page size, sorting, and outputting URIs.

```APIDOC
## gcloud alloydb users list

### Description
Lists AlloyDB users in a given cluster.

### Method
GET

### Endpoint
`gcloud alloydb users list`

### Parameters
#### Path Parameters
None

#### Query Parameters
- `--cluster` (string) - Required - AlloyDB cluster ID
- `--region` (string) - Required - Regional location (e.g. `asia-east1`, `us-east1`). See the full list of regions at https://cloud.google.com/sql/docs/instance-locations.
- `--filter` (string) - Optional - Apply a Boolean filter `EXPRESSION` to each resource item to be listed. For more details and examples of filter expressions, run $ gcloud topic filters.
- `--limit` (integer) - Optional - Maximum number of resources to list. The default is `unlimited`.
- `--page-size` (integer) - Optional - Maximum number of resources per page. The default is determined by the service if it supports paging, otherwise it is `unlimited`.
- `--sort-by` (list of strings) - Optional - Comma-separated list of resource field key names to sort by. Prefix a field with ``~´´ for descending order on that field.
- `--uri` (boolean) - Optional - Print a list of resource URIs instead of the default output.

### Request Example
```bash
gcloud alloydb users list --cluster=my-cluster --region=us-central1
```

### Response
#### Success Response (200)
- **fields** (object) - Details of the AlloyDB users.

#### Response Example
```json
{
  "users": [
    {
      "name": "projects/my-project/instances/my-cluster/users/user1",
      "state": "READY",
      "createTime": "2023-01-01T10:00:00Z"
    },
    {
      "name": "projects/my-project/instances/my-cluster/users/user2",
      "state": "READY",
      "createTime": "2023-01-02T11:00:00Z"
    }
  ]
}
```
```

--------------------------------

### Connection pooling query wait timeout

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The query wait timeout for managed connection pooling.

```bash
--connection-pooling-query-wait-timeout=`CONNECTION_POOLING_QUERY_WAIT_TIMEOUT`
```

--------------------------------

### Access Level File Structure

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/levels/replace-all

This YAML structure defines the access levels to be applied to a policy. It includes basic and custom level configurations with conditions.

```yaml
- name: accessPolicies/my_policy/accessLevels/my_level
  title: My Basic Level
  description: Basic level for foo.
  basic:
    combiningFunction: AND
    conditions:
    - ipSubnetworks:
      - 192.168.100.14/24
      - 2001:db8::/48
    - members
      - user1:user1@example.com
- name: accessPolicies/my_policy/accessLevels/my_other_level
  title: My Other Custom Level
  description: Custom level for bar.
  custom:
    expr:
      expression: "origin.region_code in ['US', 'CA']"

```

--------------------------------

### Connection pooling max pool size

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The maximum pool size for managed connection pooling.

```bash
--connection-pooling-max-pool-size=`CONNECTION_POOLING_MAX_POOL_SIZE`
```

--------------------------------

### Connection Pooling Options

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Configure managed connection pooling settings for the AlloyDB instance.

```APIDOC
## Connection Pooling Options

### Description
Configure managed connection pooling settings for the AlloyDB instance.

### Parameters
#### Query Parameters
- **--connection-pooling-max-connections** (integer) - The max client connections for managed connection pooling.
- **--connection-pooling-max-pool-size** (integer) - The max pool size for managed connection pooling.
- **--connection-pooling-max-prepared-statements** (integer) - The maximum number of prepared statements allowed.
- **--connection-pooling-min-pool-size** (integer) - The min pool size for managed connection pooling.
- **--connection-pooling-pool-mode** (string) - The pool mode for managed connection pooling. Must be one of: `SESSION`, `TRANSACTION`.
- **--connection-pooling-query-wait-timeout** (duration) - The query wait timeout for managed connection pooling.
- **--connection-pooling-server-idle-timeout** (duration) - The server idle timeout for managed connection pooling.
- **--connection-pooling-server-lifetime** (duration) - The lifetime of a server connection in seconds. The pooler will close an unused server connection that has been connected longer than this. Setting it to 0 means the connection is to be used only once, then closed.
- **--connection-pooling-stats-users** (list of strings) - Comma-separated list of database users to access connection pooling stats.
- **--[no-]enable-connection-pooling** (boolean) - Enable or disable connection pooling for the instance. Use `--enable-connection-pooling` to enable and `--no-enable-connection-pooling` to disable.
```

--------------------------------

### gcloud access-context-manager policies update

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Update an existing access policy.

```APIDOC
## gcloud access-context-manager policies update

### Description
Update an existing access policy.

### Method
`gcloud access-context-manager policies update`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies update POLICY_NAME --etag=ETAG
```

### Response
None explicitly defined for this command, success is indicated by exit code.
```

--------------------------------

### List Model Garden Endpoints in a Specific Region

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/endpoints/list

This command lists only those Vertex AI endpoints that are specifically created from Model Garden within the given project and region. This is useful for isolating endpoints managed by Model Garden.

```bash
gcloud ai endpoints list --project=example --region=us-central1 --list-model-garden-endpoints-only
```

--------------------------------

### Approve an Access Approval request

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval/requests/approve

Approves a specific request using its resource name.

```bash
gcloud access-approval requests approve projects/12345/approvalRequests/abc123
```

--------------------------------

### Private Service Connect (PSC) Connectivity

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Configure Private Service Connect (PSC) connectivity for the AlloyDB instance.

```APIDOC
## Private Service Connect (PSC) Connectivity

### Description
Configure Private Service Connect (PSC) connectivity for the AlloyDB instance.

### Parameters
#### Query Parameters
- **--psc-auto-connections** (list of objects) - Comma-separated list of consumer project and consumer network pairs to create endpoints for Private Service Connect (PSC) connectivity for the instance. Only instances in PSC-enabled clusters are allowed to set this field. Both project and network must be specified. (e.g., `--psc-auto-connections=project=project1,network=projects/vpc-host-project1/global/networks/network1` `--psc-auto-connections=project=project2,network=projects/vpc-host-project2/global/networks/network2`). Sets `psc_auto_connections` value.
  - **network** (string) - Required, sets `network` value.
  - **project** (string) - Required, sets `project` value.
  Shorthand Example:
  `--psc-auto-connections=network=string,project=string`
  JSON Example:
  `--psc-auto-connections='{"network": "string", "project": "string"}'`
  File Example:
  `--psc-auto-connections=path_to_file.(yaml|json)`
- **--psc-network-attachment-uri** (string) - Full URI of the network attachment that is configured to support outbound connectivity from an AlloyDB instance which uses Private Service Connect (PSC). For example, this would be of the form: `psc-network-attachment-uri=projects/test-project/regions/us-central1/networkAttachments/my-na`
```

--------------------------------

### gcloud access-context-manager policies - Overview

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

The `gcloud access-context-manager policies` command group is used to manage Access Context Manager policies. A policy serves as a container for access levels and access zones.

```APIDOC
## gcloud access-context-manager policies

### Description
Manage Access Context Manager policies. An access policy is a container for access levels and access zones.

### Synopsis
`gcloud access-context-manager policies` COMMAND [GCLOUD_WIDE_FLAG …]

### Commands
- `add-iam-policy-binding`: Add IAM policy binding for an access policy.
- `create`: Create a new access policy.
- `delete`: Delete an access policy.
- `describe`: Show details about an access policy.
- `get-iam-policy`: Get the IAM policy for an access policy.
- `list`: List access policies.
- `remove-iam-policy-binding`: Remove IAM policy binding for an access policy.
- `set-iam-policy`: Set IAM policy for an access policy.
- `update`: Update an existing access policy.

### Gcloud Wide Flags
These flags are available to all commands:
- `--help`: Display help for a command.

Run `$ gcloud help` for details.
```

--------------------------------

### gcloud beta alloydb users set-password

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/set-password

This is a beta version of the command to set an AlloyDB user's password.

```bash
gcloud beta alloydb users set-password
```

--------------------------------

### Database Flags

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Set specific database flags on the AlloyDB instance.

```APIDOC
## Database Flags

### Description
Set specific database flags on the AlloyDB instance.

### Parameters
#### Query Parameters
- **--database-flags** (list of strings) - Comma-separated list of database flags to set on the instance. Use an equals sign to separate flag name and value. Flags without values, like `skip_grant_tables`, can be written out without a value after, e.g., `skip_grant_tables=`. Use `on`/`off` for booleans. View the Instance Resource API for allowed flags. (e.g., `--database-flags max_allowed_packet=55555,skip_grant_tables=,log_output=1`)
```

--------------------------------

### gcloud beta ai-platform local predict variant

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

This is a beta version of the local prediction command. It offers more features than the stable version but may still undergo changes.

```bash
gcloud beta ai-platform local predict
```

--------------------------------

### SSL Mode

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Specify the SSL mode for database connections.

```APIDOC
## SSL Mode

### Description
Specify the SSL mode for database connections.

### Parameters
#### Query Parameters
- **--ssl-mode** (string) - Specify the SSL mode to use when the instance connects to the database. Default SSL mode will match what is set on the primary instance. `SSL_MODE` must be one of: `ALLOW_UNENCRYPTED_AND_ENCRYPTED`, `ENCRYPTED_ONLY`.
  - `ALLOW_UNENCRYPTED_AND_ENCRYPTED`: SSL connections are optional. CA verification is not enforced.
  - `ENCRYPTED_ONLY`: SSL connections are required. CA verification is not enforced.
```

--------------------------------

### gcloud access-context-manager policies create

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/create

Creates a new Access Context Manager policy. An access policy is a container for access levels and VPC Service Controls service perimeters. You can optionally scope the policy to a specific folder or project within the organization.

```APIDOC
## gcloud access-context-manager policies create

### Description
Create a new Access Context Manager policy. An Access Context Manager policy, also known as an access policy, is a container for access levels and VPC Service Controls service perimeters.
You can optionally specify either a folder or a project as a scope of an access policy. A scoped policy only allows projects under that scope to be restricted by any service perimeters defined with that policy. The scope must be within the organization that this policy is associated with. You can specify only one folder or project as the scope for an access policy. If you don't specify a scope, then the scope extends to the entire organization and any projects within the organization can be added to service perimeters in this policy.
This command only creates an access policy. Access levels and service perimeters need to be created explicitly.

### Method
`gcloud access-context-manager policies create`

### Endpoint
N/A (CLI command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Flags
#### Required Flags
* `--organization` (string) - Parent organization for the access policies.
* `--title` (string) - Short human-readable title of the access policy.

#### Optional Flags
* `--async` - Return immediately, without waiting for the operation in progress to complete.
* `--scopes` (list) - Folder or project on which this policy is applicable. You can specify only one folder or project as the scope and the scope must exist within the specified organization. If you don't specify a scope, the policy applies to the entire organization.

### Examples
To create an access policy that applies to the entire organization:
```bash
gcloud access-context-manager policies create --organization=organizations/123 --title="My Policy"
```

To create an access policy that applies to the folder with the ID 345:
```bash
gcloud access-context-manager policies create --organization=organizations/123 --scopes=folders/345 --title="My Folder Policy"
```

To create an access policy that applies only to the project with the project number 567:
```bash
gcloud access-context-manager policies create --organization=organizations/123 --scopes=projects/567 --title="My Project Policy"
```

### API Reference
This command uses the `accesscontextmanager/v1` API. The full documentation for this API can be found at: https://cloud.google.com/access-context-manager/docs/reference/rest/
```

--------------------------------

### Replace All Access Levels with Etag

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/levels/replace-all

Use this command to replace all access levels in a policy when you have the latest etag. This ensures you are working with the most current version of the policy.

```bash
gcloud access-context-manager levels replace-all my-policy-number --source-file=path-to-file-containing-all-replacement-access-levels.yaml --etag=optional-latest-etag-of-policy
```

--------------------------------

### gcloud access-approval service-account

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval

Manage Access Approval service account.

```APIDOC
## gcloud access-approval service-account

### Description
Manage Access Approval service account.

### Synopsis
`gcloud access-approval service-account` GROUP [`GCLOUD_WIDE_FLAG …`]

### Groups
``GROUP`` is one of the following:

`get-iam-policy`
    Gets the IAM policy for the Access Approval service account.

`set-iam-policy`
    Sets the IAM policy for the Access Approval service account.
```

--------------------------------

### Connection pooling server idle timeout

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The server idle timeout for managed connection pooling.

```bash
--connection-pooling-server-idle-timeout=`CONNECTION_POOLING_SERVER_IDLE_TIMEOUT`
```

--------------------------------

### Connection pooling server lifetime

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The lifetime of a server connection in seconds. Setting to 0 means the connection is used only once, then closed.

```bash
--connection-pooling-server-lifetime=`CONNECTION_POOLING_SERVER_LIFETIME`
```

--------------------------------

### gcloud ai models copy

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/models/copy

Copies a specified AI model to a new location or as a new version.

```APIDOC
## gcloud ai models copy

### Description
Copies a model from a source project and location to a destination. This can be used to create a new model with a different ID or to add a new version to an existing model.

### Method
`gcloud ai models copy`

### Endpoint
Not applicable (this is a CLI command, not a direct API endpoint).

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (parameters are passed as flags)

#### Flags
* `--source-model` (string, Required): The resource name of the Model to copy. Format: `projects/{project}/locations/{location}/models/{model}`.
* `--kms-key-name` (string, Optional): The Cloud KMS resource identifier for the customer-managed encryption key. Format: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. The key must be in the same region as the destination.
* `--region` (string, Optional): ID of the region or fully qualified identifier for the region where the model will be copied to. Can be set via `--region` flag, `ai/region` property, or prompted.
* `--destination-model-id` (string, Optional): Copy source_model into a new Model with this ID. The ID must be 63 characters or less and contain only `[a-z0-9\-]`. The first character cannot be a number or hyphen.
* `--destination-parent-model` (string, Optional): Specify this field to copy source_model into this existing Model as a new version. Format: `projects/{project}/locations/{location}/models/{model}`.

### Request Example
```bash
gcloud ai models copy --source-model=projects/example/locations/us-central1/models/123 --region=projects/example/locations/europe-west4
```

### Response
#### Success Response (200)
Details of the copied model are returned.

#### Response Example
```json
{
  "name": "projects/example/locations/europe-west4/models/123",
  "displayName": "123",
  "createTime": "2023-01-01T10:00:00Z",
  "updateTime": "2023-01-01T10:05:00Z"
}
```

### Error Handling
Standard gcloud error formats will be returned for invalid arguments or API errors.
```

--------------------------------

### gcloud access-context-manager policies add-iam-policy-binding

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Add an IAM policy binding to an existing access policy.

```APIDOC
## gcloud access-context-manager policies add-iam-policy-binding

### Description
Add IAM policy binding for an access policy.

### Method
`gcloud access-context-manager policies add-iam-policy-binding`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies add-iam-policy-binding POLICY_NAME \
    --member=MEMBER \
    --role=ROLE
```

### Response
None explicitly defined for this command, success is indicated by exit code.
```

--------------------------------

### Connection pooling pool mode

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

The pool mode for managed connection pooling. Must be SESSION or TRANSACTION.

```bash
--connection-pooling-pool-mode=`CONNECTION_POOLING_POOL_MODE`
```

--------------------------------

### Delete an authorized organizations description

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/authorized-orgs/delete

Use this command to delete an existing authorized organizations description. Ensure you provide the description ID.

```bash
gcloud access-context-manager authorized-orgs delete my_authorized_orgs_desc_id
```

--------------------------------

### gcloud ai custom-jobs describe

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai/custom-jobs/describe

Retrieves detailed information about a custom job using its ID and region.

```APIDOC
## GET /v1/projects/{projectId}/locations/{locationId}/customJobs/{customJobId}

### Description
Retrieves detailed information about a specific custom job.

### Method
GET

### Endpoint
`/v1/projects/{projectId}/locations/{locationId}/customJobs/{customJobId}`

### Parameters
#### Path Parameters
- **customJobId** (string) - Required - The ID of the custom job to describe.
- **locationId** (string) - Required - The Cloud region for the custom job.

#### Query Parameters
- **projectId** (string) - Optional - The Google Cloud project ID. If not specified, the default project is used.

### Request Example
```bash
gcloud ai custom-jobs describe 123 --project=example --region=us-central1
```

### Response
#### Success Response (200)
- **name** (string) - The resource name of the custom job.
- **displayName** (string) - The user-specified display name of the custom job.
- **state** (string) - The state of the custom job.
- **createTime** (string) - The time the custom job was created.
- **startTime** (string) - The time the custom job was started.
- **endTime** (string) - The time the custom job ended.
- **region** (string) - The region where the custom job is running.

#### Response Example
```json
{
  "name": "projects/example/locations/us-central1/customJobs/123",
  "displayName": "My Custom Job",
  "state": "SUCCEEDED",
  "createTime": "2023-01-01T10:00:00Z",
  "startTime": "2023-01-01T10:05:00Z",
  "endTime": "2023-01-01T11:00:00Z",
  "region": "us-central1"
}
```
```

--------------------------------

### gcloud Global Flags

Source: https://docs.cloud.google.com/sdk/gcloud/reference

The gcloud CLI provides a set of global flags that can be used with any gcloud command to modify its behavior. These flags control aspects like authentication, project selection, output format, and verbosity.

```APIDOC
## gcloud Global Flags

### Description
Global flags are options that can be applied to any `gcloud` command to modify its behavior. They control aspects such as authentication, project targeting, output formatting, and verbosity.

### Method
N/A (Global Flags)

### Endpoint
N/A (Global Flags)

### Parameters
#### Global Flags
- **--account** (string) - Google Cloud user account to use for invocation. Overrides the default `core/account` property value for this command invocation.
- **--billing-project** (string) - The Google Cloud project that will be charged quota for operations performed in `gcloud`. If you need to operate on one project, but need quota against a different project, you can use this flag to specify the billing project. If both `billing/quota_project` and `--billing-project` are specified, `--billing-project` takes precedence.
- **--configuration** (string) - File name of the configuration to use for this command invocation. For more information on how to use configurations, run: `gcloud topic configurations`. You can also use the CLOUDSDK_ACTIVE_CONFIG_NAME environment variable to set the equivalent of this flag for a terminal session.
- **--flags-file** (string) - A YAML or JSON file that specifies a `--flag`:`value` dictionary. Useful for specifying complex flag values with special characters that work with any command interpreter. Additionally, each `--flags-file` arg is replaced by its constituent flags. See $ gcloud topic flags-file for more information.
- **--flatten** (list of strings) - Flatten `name`[] output resource slices in `KEY` into separate records for each item in each slice. Multiple keys and slices may be specified. This also flattens keys for `--format` and `--filter`. For example, `--flatten=abc.def` flattens `abc.def[].ghi` references to `abc.def.ghi`. A resource record containing `abc.def[]` with N elements will expand to N records in the flattened output. This allows us to specify what `resource-key` the `filter` will operate on. This flag interacts with other flags that are applied in this order: `--flatten`, `--sort-by`, `--filter`, `--limit`.
- **--format** (string) - Sets the format for printing command output resources. The supported formats are limited to: `config`, `csv`, `default`, `diff`, `disable`, `flattened`, `get`, `json`, `list`, `multi`, `none`, `object`, `table`, `text`, `value`, `yaml`. For more details run $ gcloud topic formats.
- **--help** - Display detailed help.
- **--project** (string) - The Google Cloud project ID to use for this invocation. If omitted, then the current project is assumed; the current project can be listed using `gcloud config list --format='text(core.project)'` and can be set using `gcloud config set project PROJECTID`. `--project` and its fallback `core/project` property play two roles in the invocation. It specifies the project of the resource to operate on. It also specifies the project for API enablement check, quota, and billing. To specify a different project for quota and billing, use `--billing-project` or `billing/quota_project` property.
- **--quiet**, **-q** - Disable all interactive prompts when running `gcloud` commands. If input is required, defaults will be used, or an error will be raised. Overrides the default core/disable_prompts property value for this command invocation. This is equivalent to setting the environment variable `CLOUDSDK_CORE_DISABLE_PROMPTS` to 1.
- **--verbosity** (string) - Override the default verbosity for this command. `VERBOSITY` must be one of: `debug`, `info`, `warning`, `error`, `critical`, `none`. Overrides the default `core/verbosity` property value for this command invocation.
- **--version**, **-v** - Print version information and exit. This flag is only available at the global level.
- **-h** - Display detailed help.
- **--access-token-file** (string) - Path to a file containing an access token.
- **--impersonate-service-account** (list of strings) - Service account to impersonate for the current command.
- **--log-http** - Log all HTTP requests made by gcloud.
- **--trace-token** (string) - Token to use for tracing requests.
- **--no-user-output-enabled** - Disable user output for the command.

### Request Example
N/A (Global Flags)

### Response
N/A (Global Flags)
```

--------------------------------

### gcloud access-context-manager policies set-iam-policy

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Set the IAM policy for an access policy.

```APIDOC
## gcloud access-context-manager policies set-iam-policy

### Description
Set IAM policy for an access policy.

### Method
`gcloud access-context-manager policies set-iam-policy`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies set-iam-policy POLICY_NAME IAM_POLICY_FILE
```

### Response
None explicitly defined for this command, success is indicated by exit code.
```

--------------------------------

### Outbound Public IP and Connector Enforcement

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/instances/create-secondary

Configure outbound public IP connectivity and enforce connector-only connections.

```APIDOC
## Outbound Public IP and Connector Enforcement

### Description
Configure outbound public IP connectivity and enforce connector-only connections.

### Parameters
#### Query Parameters
- **--[no-]outbound-public-ip** (boolean) - Add outbound Public IP connectivity to an AlloyDB instance. Use `--outbound-public-ip` to enable and `--no-outbound-public-ip` to disable.
- **--[no-]require-connectors** (boolean) - Enable or disable enforcing connectors only (ex: AuthProxy) connections to the database. Use `--require-connectors` to enable and `--no-require-connectors` to disable.
```

--------------------------------

### gcloud alpha ai-platform local predict variant

Source: https://docs.cloud.google.com/sdk/gcloud/reference/ai-platform/local/predict

This is an alpha version of the local prediction command. Use with caution as it may be unstable or change.

```bash
gcloud alpha ai-platform local predict
```

--------------------------------

### Replace All Access Levels without Etag

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/levels/replace-all

Use this command to replace all access levels in a policy when the etag is not available or not required. This is a simpler method for updating all levels.

```bash
gcloud access-context-manager levels replace-all my-policy-number --source-file=path-to-file-containing-all-replacement-access-levels.yaml
```

--------------------------------

### gcloud alpha alloydb users set-password

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/set-password

This is an alpha version of the command to set an AlloyDB user's password.

```bash
gcloud alpha alloydb users set-password
```

--------------------------------

### gcloud access-context-manager policies get-iam-policy

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Retrieve the IAM policy associated with an access policy.

```APIDOC
## gcloud access-context-manager policies get-iam-policy

### Description
Get the IAM policy for an access policy.

### Method
`gcloud access-context-manager policies get-iam-policy`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies get-iam-policy POLICY_NAME
```

### Response
#### Success Response (200)
The IAM policy document for the specified access policy.

#### Response Example
```json
{
  "bindings": [
    {
      "role": "roles/accesscontextmanager.policyAdmin",
      "members": [
        "user:user@example.com"
      ]
    }
  ],
  "etag": "etag123"
}
```
```

--------------------------------

### Delete an authorized organizations description (alpha)

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/authorized-orgs/delete

This is an alternative variant for deleting an authorized organizations description, potentially using alpha features. Use with caution.

```bash
gcloud alpha access-context-manager authorized-orgs delete
```

--------------------------------

### gcloud access-approval requests approve

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-approval/requests/approve

Approves an Access Approval request. An error will be raised if the request does not exist or is not in a pending state.

```APIDOC
## POST /v1/accessapproval/projects/{projectsId}/approvalRequests/{approvalRequestsId}:approve

### Description
Approve an Access Approval request. This will raise an error if the request does not exist or is not in a pending state.

### Method
POST

### Endpoint
`gcloud access-approval requests approve NAME`

### Parameters
#### Path Parameters
- **NAME** (string) - Required - Name of the Access Approval request to invalidate. Example: `projects/12345/approvalRequests/abc123`

#### Query Parameters
None

#### Request Body
None

### Request Example
```
gcloud access-approval requests approve projects/12345/approvalRequests/abc123
```

### Response
#### Success Response (200)
This command does not return a response body upon successful approval. The success is indicated by the absence of errors.

#### Response Example
None
```

--------------------------------

### gcloud access-context-manager perimeters Overview

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

The `gcloud access-context-manager perimeters` command group is used to manage service perimeters. A service perimeter restricts data movement between Google Cloud resources.

```APIDOC
## gcloud access-context-manager perimeters

### Description
Manages Access Context Manager service perimeters. A service perimeter describes a set of Google Cloud Platform resources which can freely import and export data amongst themselves, but not externally. Currently, the only allowed members of a service perimeter are projects.

### Groups
- `dry-run`: Enable management of dry-run mode configuration for Service Perimeters.

### Commands
- `create`: Create a new service perimeter.
- `delete`: Delete a service perimeter.
- `describe`: Show details about a service perimeter.
- `list`: List service perimeters.
- `replace-all`: Replace all existing service perimeters.
- `update`: Update the enforced configuration for an existing Service Perimeter.
```

--------------------------------

### Update a Service Perimeter

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

Use the `update` command to modify an existing service perimeter's enforced configuration.

```APIDOC
## PATCH /api/access-context-manager/v1/perimeters/{name}

### Description
Updates the enforced configuration for an existing Service Perimeter.

### Method
PATCH

### Endpoint
`/api/access-context-manager/v1/perimeters/{name}`

### Parameters
#### Path Parameters
- **name** (string) - Required - The resource name of the Service Perimeter to update. Example: `organizations/123/locations/global/servicePerimeters/myPerimeter`.

#### Request Body
- **title** (string) - Optional - A human-readable title for the Service Perimeter.
- **resources** (array of strings) - Optional - A list of Google Cloud resource names that are part of this Service Perimeter. Example: `["projects/12345"]`.
- **restrictedServices** (array of strings) - Optional - A list of Google Cloud services that are restricted from being accessed from outside the perimeter. Example: `["storage.googleapis.com"]`.
- **ingressPolicies** (array of objects) - Optional - Defines the conditions for traffic ingress into the perimeter.
- **egressPolicies** (array of objects) - Optional - Defines the conditions for traffic egress from the perimeter.
- **updateMask** (string) - Optional - Field mask to determine which fields to update.

### Request Example
```json
{
  "resources": ["projects/12345", "projects/67890"],
  "updateMask": "resources"
}
```

### Response
#### Success Response (200)
- **name** (string) - The resource name of the Service Perimeter.
- **title** (string) - The human-readable title of the Service Perimeter.
- **resources** (array of strings) - The list of Google Cloud resources included in the perimeter.
- **restrictedServices** (array of strings) - The list of restricted services.
- **ingressPolicies** (array of objects) - The ingress policies.
- **egressPolicies** (array of objects) - The egress policies.

#### Response Example
```json
{
  "name": "organizations/123/locations/global/servicePerimeters/myPerimeter",
  "title": "My Perimeter",
  "resources": ["projects/12345", "projects/67890"],
  "restrictedServices": [],
  "ingressPolicies": [],
  "egressPolicies": []
}
```
```

--------------------------------

### gcloud active-directory domains trusts update

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/trusts

Updates target DNS IP addresses for a Managed Microsoft AD trust.

```APIDOC
## gcloud active-directory domains trusts update

### Description
Update target DNS IP addresses for a Managed Microsoft AD trust.

### Method
CLI Command

### Endpoint
gcloud active-directory domains trusts update
```

--------------------------------

### Delete a Service Perimeter

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters

Use the `delete` command to remove an existing service perimeter.

```APIDOC
## DELETE /api/access-context-manager/v1/perimeters/{name}

### Description
Deletes a service perimeter.

### Method
DELETE

### Endpoint
`/api/access-context-manager/v1/perimeters/{name}`

### Parameters
#### Path Parameters
- **name** (string) - Required - The resource name of the Service Perimeter to delete. Example: `organizations/123/locations/global/servicePerimeters/myPerimeter`.

### Response
#### Success Response (200)
An empty response body indicates successful deletion.

#### Response Example
```json
{}
```
```

--------------------------------

### gcloud active-directory domains trusts create

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/trusts

Creates a Microsoft Active Directory Trust between a Managed Microsoft AD domain and another domain.

```APIDOC
## gcloud active-directory domains trusts create

### Description
Create a Microsoft Active Directory Trust between a Managed Microsoft AD domain and another domain.

### Method
CLI Command

### Endpoint
gcloud active-directory domains trusts create
```

--------------------------------

### gcloud active-directory domains trusts validate-state

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/trusts

Validates the state of a Managed Microsoft AD trust.

```APIDOC
## gcloud active-directory domains trusts validate-state

### Description
Validate the state of a Managed Microsoft AD trust.

### Method
CLI Command

### Endpoint
gcloud active-directory domains trusts validate-state
```

--------------------------------

### Update AlloyDB User Password

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/set-password

Use this command to update an AlloyDB user's password. Ensure you have the correct username, cluster ID, region, and the new password.

```bash
gcloud alloydb users set-password my-username --cluster=my-cluster --region=us-central1 --password=postgres
```

--------------------------------

### gcloud access-context-manager policies delete

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies/delete

Deletes a specified access policy. You can identify the policy by its ID or a fully qualified identifier.

```APIDOC
## DELETE /v1/accessPolicies/{policyId}

### Description
Deletes a given access policy.

### Method
DELETE

### Endpoint
`accessPolicies/{policyId}`

### Parameters
#### Path Parameters
- **policyId** (string) - Required - The ID of the policy to delete.

### Request Body
This endpoint does not accept a request body.

### Response
#### Success Response (200)
This endpoint returns an empty response body on success.

#### Response Example
(No response body)
```

--------------------------------

### gcloud access-context-manager authorized-orgs delete

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/authorized-orgs/delete

Deletes an authorized organizations description in a given access policy.

```APIDOC
## gcloud access-context-manager authorized-orgs delete

### Description
Delete an authorized organizations description in a given access policy.

### Method
DELETE

### Endpoint
`gcloud access-context-manager authorized-orgs delete [AUTHORIZED_ORGS_DESC]`

### Parameters
#### Path Parameters
- **AUTHORIZED_ORGS_DESC** (string) - Required - ID of the authorized-orgs-desc or fully qualified identifier for the authorized-orgs-desc.

#### Query Parameters
- **--policy** (string) - Required - The ID of the access policy.
- **--async** (boolean) - Optional - Return immediately, without waiting for the operation in progress to complete.

### Request Example
```bash
gcloud access-context-manager authorized-orgs delete my_authorized_orgs_desc_id --policy=YOUR_POLICY_ID
```

### Response
#### Success Response (200)
This command does not explicitly define a success response body in the documentation. Typically, a successful deletion operation might return an empty body or a status indicating success.

#### Response Example
(No specific example provided in the documentation.)

### API Reference
This command uses the `accesscontextmanager/v1` API. See: https://cloud.google.com/access-context-manager/docs/reference/rest/
```

--------------------------------

### gcloud access-context-manager policies remove-iam-policy-binding

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/policies

Remove an IAM policy binding from an access policy.

```APIDOC
## gcloud access-context-manager policies remove-iam-policy-binding

### Description
Remove IAM policy binding for an access policy.

### Method
`gcloud access-context-manager policies remove-iam-policy-binding`

### Endpoint
Not applicable (gcloud command)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (uses gcloud flags)

### Request Example
```bash
gcloud access-context-manager policies remove-iam-policy-binding POLICY_NAME \
    --member=MEMBER \
    --role=ROLE
```

### Response
None explicitly defined for this command, success is indicated by exit code.
```

--------------------------------

### gcloud alloydb users set-password

Source: https://docs.cloud.google.com/sdk/gcloud/reference/alloydb/users/set-password

Updates an AlloyDB user's password within a specified cluster and region.

```APIDOC
## POST /gcloud/alloydb/users/set-password

### Description
Updates an AlloyDB user's password within a given cluster and region.

### Method
POST

### Endpoint
`/gcloud/alloydb/users/set-password`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **USERNAME** (string) - Required - AlloyDB username
- **cluster** (string) - Required - AlloyDB cluster ID
- **password** (string) - Required - Password for this database user
- **region** (string) - Required - Regional location (e.g. `asia-east1`, `us-east1`). See the full list of regions at https://cloud.google.com/sql/docs/instance-locations.

### Request Example
```json
{
  "USERNAME": "my-username",
  "cluster": "my-cluster",
  "region": "us-central1",
  "password": "postgres"
}
```

### Response
#### Success Response (200)
This command does not return a response body upon successful execution. Success is indicated by the absence of errors.

#### Response Example
None
```

--------------------------------

### gcloud access-context-manager perimeters delete

Source: https://docs.cloud.google.com/sdk/gcloud/reference/access-context-manager/perimeters/delete

Deletes a service perimeter in a given access policy. You must specify the perimeter to delete and the policy it belongs to.

```APIDOC
## gcloud access-context-manager perimeters delete

### Description
Delete a service perimeter in a given access policy.

### Method
DELETE

### Endpoint
`gcloud access-context-manager perimeters delete`

### Parameters
#### Path Parameters
- **PERIMETER** (string) - Required - ID of the perimeter or fully qualified identifier for the perimeter.

#### Query Parameters
- **--policy** (string) - Required - The ID of the access policy.
- **--async** (boolean) - Optional - Return immediately, without waiting for the operation in progress to complete.

### Request Example
```bash
gcloud access-context-manager perimeters delete PERIMETER --policy=POLICY
```

### Response
#### Success Response (200)
This command does not explicitly define a success response body in the documentation. Typically, a successful deletion would result in an empty response body or a status indicating completion.

#### Response Example
(No specific example provided in the documentation.)
```

--------------------------------

### gcloud active-directory domains trusts delete

Source: https://docs.cloud.google.com/sdk/gcloud/reference/active-directory/domains/trusts

Deletes an Active Directory Trust between a Managed Microsoft AD domain and a target domain.

```APIDOC
## gcloud active-directory domains trusts delete

### Description
Delete an Active Directory Trust between a Managed Microsoft AD domain and a target domain.

### Method
CLI Command

### Endpoint
gcloud active-directory domains trusts delete
```

=== COMPLETE CONTENT === This response contains all available snippets from this library. No additional content exists. Do not make further requests.
