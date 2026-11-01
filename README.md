# Legacy .NET learning templates

This repository contains older C#/.NET practice projects and architecture experiments. It is provided as historical example source, not as a maintained production-ready template.

## Included samples

- `km-domain-driven-development-sdk-templete/` — domain/service and SDK layering experiment.
- `km-webapi-template/` — ASP.NET Core Web API template experiment.

The source projects retain their original dependencies and may require an older .NET SDK. Review and upgrade dependencies before reuse.

## Public-repository hygiene

Generated build output, Visual Studio caches, local settings, and per-user project files should not be committed. The root `.gitignore` blocks common artifacts, and existing tracked generated artifacts are removed in the privacy-cleanup change.

**Historical note:** Removing a file from the current branch does not remove its contents from earlier public commits. Do not publish secrets or personal data in this or any other public repository.
