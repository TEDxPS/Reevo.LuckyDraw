import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'LuckyDraw',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44386/',
    redirectUri: baseUrl,
    clientId: 'LuckyDraw_App',
    responseType: 'code',
    scope: 'offline_access LuckyDraw',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44386',
      rootNamespace: 'Reevo.LuckyDraw',
    },
    LuckyDraw: {
      url: 'https://localhost:44390',
      rootNamespace: 'Reevo.LuckyDraw',
    },
  },
} as Environment;
