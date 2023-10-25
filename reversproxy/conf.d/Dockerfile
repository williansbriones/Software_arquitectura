#descarga la imagen de nginx
FROM nginx:latest
#Copia la configuracion que le das al servidor
#y la pega en los documentos del contenedor 
COPY default.conf /etc/nginx/conf.d/default.conf
#expone el pueto 443
EXPOSE 443