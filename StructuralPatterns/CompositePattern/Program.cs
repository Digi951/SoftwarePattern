using CompositePattern.Composite;
using CompositePattern.Leaf;

DirectoryComposite videokurs = new("videokurs");

FileLeaf kursskript = new("kursskript", "Jim Panse");
DirectoryComposite videos = new("videos");

videokurs.Add(kursskript);
videokurs.Add(videos);

FileLeaf video1 = new("video_1", "Jim Panse");
FileLeaf video2 = new("video_2", "Jim Panse");

videos.Add(video1);
videos.Add(video2);

videokurs.Print("");

Console.ReadKey();

