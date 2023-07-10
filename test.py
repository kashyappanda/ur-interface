import URBasic
import time


host = '192.168.0.113'   #E.g. a Universal Robot offline simulator, please adjust to match your IP
acc = 0.9
vel = 0.9


def RobotHome():
	'''
	This is a small example of how to connect to a Universal Robots robot and use a few simple script commands. 
	The scrips available is in general all the scrips from the universal robot script manual, 
	and the implementation is intended to follow the Universal Robots manual as much as possible.  
	
	This script can be run connected to a Universal Robot robot (tested at a UR5) or a Universal Robot offline simulator. 
	See this example in how to setup an offline simulator: 
	https://www.universal-robots.com/download/?option=26266#section16597
	'''
	robotModel = URBasic.robotModel.RobotModel()
	robot = URBasic.urScriptExt.UrScriptExt(host=host,robotModel=robotModel)
	robot.reset_error()
	
#	print('movej with joint specification')
#	robot.movej(q=[-3.14,-1.,0.5, -1.,-1.5,0], a=acc, v=vel)
	
	start_pose = robotModel.get_actual_tcp_pose()
	print(start_pose)
	
	robot.reset_error()
	robot.close()
	
if __name__ == '__main__':
	RobotHome()
	