import URBasic
import time

host = '10.241.34.47'   #Please adjust to match your IP

def RobotHome():
    '''
    This script can be run connected to a Universal Robot robot (tested at a UR5) or a Universal Robot offline simulator.
    See this example in how to setup an offline simulator:
    https://www.universal-robots.com/download/?option=26266#section16597
    '''
    robotModel = URBasic.robotModel.RobotModel()
    robot = URBasic.urScriptExt.UrScriptExt(host=host,robotModel=robotModel)
    robot.reset_error()
   
    robot.movej(q=[4.712398052215576, -1.5709522406207483, 8.392333984375E-5, -1.5709040800677698, -1.557509051721695E-4, -7.18275653284195E-5], a=1.3962634015954636, v=3.141592653589793)
    robot.movej(q=[3.926896572113037, -1.5709040800677698, -1.5708172957049769, -1.5710237661944788, 1.557556390762329, -3.1167665590459137E-4], a=1.3962634015954636, v=3.141592653589793)
   
    robot.reset_error()
    robot.close()
   
if __name__ == '__main__':
    RobotHome()
   
