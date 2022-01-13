# LogViewer

Over the years that I have spent as a software developer, I have realized the essence of perfect logging in application development. As part of development, writing logging statements seems to be chaotic task, although it gives a perfect solution while debugging applications especially in production environment (where we don't even have a simple CLR debugger). 

In context of production debugging logging proves a metal over other strategies, because logging becomes the only way to communicate the process that is going under the hood (application). We can neither set a debug watch nor may we have a break point to stop execution at a certain point of time. Although we may use debug.assert statement, again it is not very convenient. Altogether in my experience application seems like a black box, having no stiff controls over the execution. 

