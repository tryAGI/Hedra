# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Hedra](https://www.hedra.com/) AI video generation platform, auto-generated from the Hedra OpenAPI specification using [AutoSDK](https://github.com/tryAGI/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Hedra.slnx

# Build for release (also produces NuGet package)
dotnet build Hedra.slnx -c Release

# Run integration tests (requires HEDRA_API_KEY env var)
dotnet test src/tests/IntegrationTests/Hedra.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Hedra && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/Hedra/Generated/`.

1. `src/libs/Hedra/openapi.yaml` — the Hedra OpenAPI spec (fetched from `https://api.hedra.com/web-app/openapi.json`)
3. `src/libs/Hedra/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Hedra/` | Main SDK library (`HedraClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Hedra API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
