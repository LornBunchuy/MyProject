from django.urls import path
from . import views

urlpatterns=[
    path('homes/',views.homes, name='homes'),
    path('home/',views.home, name='home'),
    path('book/',views.book, name='book'),
    path('details/',views.details, name='details'),
    path('about/',views.about, name='about'),
    path('contact/',views.contact, name='contact'),
    path('login/',views.login, name='login'),
    path('logout/',views.logout, name='logout'),
]