namespace Game_Dev.Interfaces
{
    public interface IAnimate
    {
        public int currentFrameIndex { get; set; }
        public int holdFrame { get; set; }
    }
}
