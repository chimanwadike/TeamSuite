let app = new Vue({
	el: '#CheckListsComponent',
	vuetify: new Vuetify(),
	data: {
		headers: [{ text: 'Location', value: 'location', groupable: false }, { text: 'Action', value: 'action' }, { text: 'Status', value: 'status' }, { text: 'Submitted', value: 'completed' }],
		checklist: [],
		status_options: [{ value: '25cf2e32-36fa-47fe-a272-6afc8bd95f5c', text: 'Pending' }, { value: '9bf75416-d543-4cff-8c94-10c73d0862f1', text: 'Completed' }, { value: '62ae3adb-0603-4274-aea0-62952c3065f7', text: 'Failed' }],
		json_req_config: { headers: { 'Content-Type': 'application/json' } },
		checklist_forms: [{ id: '0ccacbc2-ca8a-426c-8461-e01047ec9765', name: 'Bezalel I.T CheckList' }],
		checklist_form: null,
		checklistobj: {},
		issue_dialog:false
	},	
	mounted: function () {
		//this.getCheckLists();
	},
	methods: {
		getCheckLists: async function () {			
			await axios
				.get('/api/checklists?checklistFormId=' + this.checklist_form)
				.then(response => this.checklist = response.data)
				.catch(error => console.log(error));
		},

		updateStatus: async function (event, checklistitem) {
			if (checklistitem.status == '62ae3adb-0603-4274-aea0-62952c3065f7') {
				this.checklistobj = checklistitem;
				console.log(this.checklistobj)
				//open issue dialog to document problem
				this.issue_dialog = true;
            }

			await axios.put('/api/checklists/' + checklistitem.id, checklistitem.status, this.json_req_config)
				.then(response => this.getCheckLists())
				.catch(error => console.log(error));
		}
	}
})