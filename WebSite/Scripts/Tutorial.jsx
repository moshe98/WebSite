var data = [
  { Author: "Daniel Lo Nigro", Text: "Hello ReactJS.NET World!" },
  { Author: "Pete Hunt", Text: "This is one comment" },
  { Author: "Jordan Walke", Text: "This is *another* comment" }
];

var Comment = React.createClass({
	render:function()
	{
		return (<div className="comment">
				&emsp; Author : {this.props.author}
				</div>);
	}
});	  

var CommentList = React.createClass({
	render: function()
	{
		var commentListNodes = this.props.data.map(
		function(comment)
		{
			return (<Comment author = {comment.Author} data = {comment.Text}>					
					</Comment>);
		});
		return (<div className="commentList">
				{commentListNodes}
				</div>);
	}
});

var CommentBox = React.createClass({
	render: function(){
		return (<div className="commentBox">
			<h1>Comments</h1>
			<CommentList  data={this.props.data} />
			</div>);
	}
});

React.render(<CommentBox data={data} />,
 document.getElementById('reactContent'));

