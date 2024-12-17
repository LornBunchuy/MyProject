from django.urls import path
from shop.views.indexview import IndexView
from shop.views.contactview import ContactView
from shop.views.productdetailsview import ProductDetailsView

urlpatterns = [
    path("categories/<int:id>",IndexView.as_view(), name="categories"),
    path("contact/",ContactView.as_view(), name="contact"),
    path("products/<int:id>",ProductDetailsView.as_view(), name="products"),
    path("",IndexView.as_view(), name="index"),
]