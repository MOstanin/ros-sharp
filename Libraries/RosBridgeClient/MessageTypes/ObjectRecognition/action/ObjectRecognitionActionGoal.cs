/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition
{
    public class ObjectRecognitionActionGoal : ActionGoal<ObjectRecognitionGoal>
    {
        public override string RosMessageName => "object_recognition_msgs/ObjectRecognitionActionGoal";

        public ObjectRecognitionActionGoal() : base()
        {
            this.goal = new ObjectRecognitionGoal();
        }

        public ObjectRecognitionActionGoal(Header header, GoalID goal_id, ObjectRecognitionGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
    }
}