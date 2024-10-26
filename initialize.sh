dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Hedra \
  HedraClient \
  https://mercury.dev.dream-ai.com/api/openapi.json \
  tryAGI \
  --output .
