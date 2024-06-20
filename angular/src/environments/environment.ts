import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AdsPortal',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44377/',
    redirectUri: baseUrl,
    clientId: 'AdsPortal_App',
    responseType: 'code',
    scope: 'offline_access AdsPortal',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44377',
      rootNamespace: 'AdsPortal',
    },
  },
} as Environment;
