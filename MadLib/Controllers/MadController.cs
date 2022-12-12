using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class MadController : Controller
  {
    [Route("/")]
    public ActionResult Home() {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string noun_one, string noun_two, string noun_three, string noun_four, string noun_five, string noun_six, string noun_seven, string noun_eight, string noun_nine, string verb_one, string verb_two, string verb_three, string adverb, string adjective) 
    {
      Story newStory = new Story();
      newStory.NounOne = noun_one;
      newStory.NounTwo = noun_two;
      newStory.NounThree = noun_three;
      newStory.NounFour = noun_four;
      newStory.NounFive = noun_five;
      newStory.NounSix = noun_six;
      newStory.NounSeven = noun_seven;
      newStory.NounEight = noun_eight;
      newStory.NounNine = noun_nine;
      newStory.VerbOne = verb_one;
      newStory.VerbTwo = verb_two;
      newStory.VerbThree = verb_three;
      newStory.Adverb = adverb;
      newStory.Adjective = adjective;
      return View(newStory);
    }
  }
}