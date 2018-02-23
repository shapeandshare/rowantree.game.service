# https://hub.docker.com/r/tiangolo/uwsgi-nginx/
FROM tiangolo/uwsgi-nginx:python2.7

WORKDIR /app

COPY ./app /app
# COPY ./dicebox/lib /app/lib
# COPY ./dicebox/dicebox.config /app

RUN pip install -r requirements.txt \
    && useradd -M -U -u 1000 trt_api_srv \
    && chown -R trt_api_srv /app

EXPOSE 80
