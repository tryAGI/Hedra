#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://api.hedra.com/web-app/openapi.json
autosdk generate openapi.json \
  --namespace Hedra \
  --clientClassName HedraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --base-url https://mercury.dev.dream-ai.com/api \
  --security-scheme ApiKey:Header:X-API-Key
