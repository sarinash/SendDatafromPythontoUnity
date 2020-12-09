
import time

from flask import Flask, jsonify, request

app = Flask(__name__)
epoch_time = int(time.time())

@app.route('/')
def index():
    return "epoch_time"


@app.route('/<epoch_time>', methods=['GET','POST'])
def get_correlations(epoch_time):
    epoch_time = int(time.time())
    my_details = {
            'name': 'Sarina',
            'request_time': epoch_time
     }

    return jsonify(my_details)


if __name__ == "__main__":
    app.run()
