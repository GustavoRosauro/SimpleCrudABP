import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'SimpleCrud',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44395',
    redirectUri: baseUrl,
    clientId: 'SimpleCrud_App',
    responseType: 'code',
    scope: 'offline_access SimpleCrud',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44395',
      rootNamespace: 'SimpleCrud',
    },
  },
} as Environment;
