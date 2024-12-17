from django.views.generic import TemplateView
from django.http import HttpResponse
from django.template import loader
from shop.models import Product
from shop.models import Category


class ProductDetailsView(TemplateView):
    template_name = "shop/productdetails.html"
    def get(self, request, id):
        categories = Category.objects.order_by("name")
        # print("product id", id)
        product = Product.objects.get(id=id)
        type = product.category.name
        context = {
            "categories": [{"id": c.id, "name": c.name}  for c in categories],
            "details": product.name,
            "title": type,
            "description": product.description,
            "price": product.price,
            "image": product.image
        }   
       
        
        template = loader.get_template(self.template_name)
        return HttpResponse(template.render(context, request))