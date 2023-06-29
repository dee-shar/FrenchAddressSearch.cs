#!/bin/bash

api="https://api-adresse.data.gouv.fr"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function search_address() {
	# 1 - parameters: (string): <parameters>
	curl --request GET \
		--url "$api/search?$1" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
