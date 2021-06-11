# Publish application & deploy to GCP

## Restore dotnet packages

```
dotnet restore
```

## Publish application

 - Debug: `dotnet publish`
 - Release: `dotnet publish -c Release`

## Deploy to GCP

```
gcloud auth login
gcloud app deploy bin/Debug/netcoreapp2.1/publish/app.yaml
```


# GCP helpful commands

## List projects

Useful for verifying the account you're using has access to the `gs-api` project.

```
gcloud projects list
```

## Tail logs

```
gcloud app logs tail -s default
```

## Open application

```
gcloud app browse
```