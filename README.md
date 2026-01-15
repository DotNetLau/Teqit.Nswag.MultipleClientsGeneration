# Teqit.Nswag.MultipeClientsGeneration

An example project to showcase how to generate separate (multiple) clients per controller.

The method used was `MultipleClientsFromOperationId`. So based on setting controller endpoint attributes correctly so the OpenApi spec contains operationIds for all endpoints we can generate multiple separate clients (per controller).
