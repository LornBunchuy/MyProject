# Generated by Django 5.1.1 on 2024-09-12 02:20

import django.db.models.deletion
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('shop', '0004_category'),
    ]

    operations = [
        migrations.AddField(
            model_name='product',
            name='Category',
            field=models.ForeignKey(default=1, on_delete=django.db.models.deletion.CASCADE, to='shop.category'),
            preserve_default=False,
        ),
    ]