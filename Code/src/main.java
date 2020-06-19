import DandD.Board;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

public class main {

    public static void main(String[] args) throws IOException {

        ArrayList<Board> levelsBoards=new ArrayList<>();
       try{

            List<String> levels= Files.list(Paths.get(args[0])).sorted().map(Path::toString).collect(Collectors.toList());
            for(String level:levels)
            {
                levelsBoards.add(toBaord(level));
            }
       }
       catch (IOException e)
       {
           e.printStackTrace();;
       }
//        while (1==1) {
//            x.playAllTurns();
//
//            System.out.println(x.toString());
//
//        }
    }

    private static Board toBaord(String level) {

        List<String> lines=Collections.EMPTY_LIST;
        try
        {
            lines=Files.readAllLines(Paths.get(level));

        }
        catch (IOException e)
        {
            e.printStackTrace();
            System.exit(-1);
        }
        return new Board(lines);
    }
}
