define(['jquery', 'knockout', './router', 'bootstrap', 'knockout-projections'], function ($, ko, router) {

  // Components can be packaged as AMD modules, such as the following:
  ko.components.register('nav-bar', { require: 'components/nav-bar/nav-bar' });
  ko.components.register('home-page', { require: 'components/home-page/home' });

  // ... or for template-only components, you can just point to a .html file directly:
  ko.components.register('about-page', {
    template: { require: 'text!components/about-page/about.html' }
  });

  ko.components.register('programme-grid', { require: 'components/programme-grid/programme-grid' });

  ko.components.register('user', { require: 'components/user/user' });

  ko.components.register('products', { require: 'components/products/products' });

  ko.components.register('product-arrays', { require: 'components/product-arrays/product-arrays' });

  ko.components.register('user-list', { require: 'components/user-list/user-list' });

  ko.components.register('user-table', { require: 'components/user-table/user-table' });

  // [Scaffolded component registrations will be inserted here. To retain this feature, don't remove this comment.]

  // Start the application
  ko.applyBindings({ route: router.currentRoute });
});
