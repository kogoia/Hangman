﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Hangman
//{
//    public class Main
//    {

//        private final InputStream input;
//    private final OutputStream output;
//    private final int max;
//        private static final String[] WORDS = {
//        "simplicity", "equality", "grandmother",
//        "neighborhood", "relationship", "mathematics",
//        "university", "explanation"
//    };

//    public Main(final InputStream in, final OutputStream out, final int m)
//        {
//            this.input = in;
//            this.output = out;
//            this.max = m;
//        }

//        public static void main(final String... args)
//        {
//            new Main(System.in, System.out, 5).exec();
//        }

//        public void exec()
//        {
//            String word = WORDS[new Random().nextInt(WORDS.length)];
//            boolean[] visible = new boolean[word.length()];
//            int mistakes = 0;
//            try (final PrintStream out = new PrintStream(this.output)) {
//                final Iterator<String> scanner = new Scanner(this.input);
//                boolean done = true;
//                while (mistakes < this.max)
//                {
//                    done = true;
//                    for (int i = 0; i < word.length(); ++i)
//                    {
//                        if (!visible[i])
//                        {
//                            done = false;
//                        }
//                    }
//                    if (done)
//                    {
//                        break;
//                    }
//                out.print("Guess a letter: ");
//                    char chr = scanner.next().charAt(0);
//                    boolean hit = false;
//                    for (int i = 0; i < word.length(); ++i)
//                    {
//                        if (word.charAt(i) == chr && !visible[i])
//                        {
//                            visible[i] = true;
//                            hit = true;
//                        }
//                    }
//                    if (hit)
//                    {
//                    out.print("Hit!\n");
//                    }
//                    else
//                    {
//                    out.printf(
//                        "Missed, mistake #%d out of %d\n",
//                        mistakes + 1, this.max
//                    );
//                        ++mistakes;
//                    }
//                out.append("The word: ");
//                    for (int i = 0; i < word.length(); ++i)
//                    {
//                        if (visible[i])
//                        {
//                        out.print(word.charAt(i));
//                        }
//                        else
//                        {
//                        out.print("?");
//                        }
//                    }
//                out.append("\n\n");
//                }
//                if (done)
//                {
//                out.print("You won!\n");
//                }
//                else
//                {
//                out.print("You lost.\n");
//                }
//            }
//            }

//}
//    }
