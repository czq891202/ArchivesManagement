export const environment = {
  production: true,
  application: {
    name: 'ArchivesManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44337',
    clientId: 'ArchivesManagement_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'ArchivesManagement',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44379',
    },
  },
  localization: {
    defaultResourceName: 'ArchivesManagement',
  },
};
