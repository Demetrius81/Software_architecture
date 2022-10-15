package Core;

import Abstractions.ItemGenerator;
import Rewards.Coopper.CooperGenerator;
import Rewards.Gam.GemGenerator;
import Rewards.Gold.GoldGenerator;
import Rewards.Mud.MudGenerator;
import Rewards.Ruby.RubyGenerator;
import Rewards.Sapphire.SapphireGenerator;
import Rewards.Silver.SilverGenerator;

import java.io.InputStream;
import java.util.*;
import java.util.concurrent.ThreadLocalRandom;

/**
 * Основной движок игры
 */
public class Core {
    /**
     * Основная логика игры
     */
    public void run() {
        List<ItemGenerator> generatorList = new ArrayList<>();

        generatorList.add(new GemGenerator());
        generatorList.add(new GoldGenerator());
        generatorList.add(new MudGenerator());
        generatorList.add(new CooperGenerator());
        generatorList.add(new RubyGenerator());
        generatorList.add(new SapphireGenerator());
        generatorList.add(new SilverGenerator());

        Random random = ThreadLocalRandom.current();
        random.ints(0, generatorList.size());

        int n = input();

        switch (n) {
            case 0:
                break;
            default: {
                for (int i = 0; i < n; i++) {
                    int indx = random.nextInt(generatorList.size());
                    ItemGenerator itemGenerator = generatorList.get(indx);
                    String str = itemGenerator.openReward();
                    System.out.println("You opened chest " + (i + 1) + ", your reward is " + str);
                }
            }
        }
        output();
    }

    /**
     * Вывод финального текста
     */
    private void output() {
        System.out.println("===============================================================");
        System.out.println("By-by, see you in next time.");
    }

    /**
     * Ввод данных и валидация
     *
     * @return введенное пользователем значение
     */
    private int input() {
        int num;
        while (true) {
            Scanner scanner = new Scanner(System.in);
            System.out.println("===============================================================");
            System.out.println("You are greeted by magical chests.");
            System.out.print("Enter the number of chests you want to open and receive rewards\nor enter 0 to exit. > ");
            try {
                num = scanner.nextInt();
            } catch (InputMismatchException ex) {
                System.err.println("You didn't enter a number.");
                continue;
            }
            if (num >= 0) {
                break;
            }
            System.err.println("The number of chests cannot be negative.");
        }
        return num;
    }
}
