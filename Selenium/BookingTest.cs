using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class BookingTest : Base
    {
        [Test]
        public void Run()
        {
            Thread.Sleep(2000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            IWebElement Cross = driver.FindElement(By.CssSelector("body.bookings2.b2.index.en.lang_is_ltr.header_reshuffle.no_bg_img.nobg.user_center.app_user_center.landing.lp_flexible_layout.sb_gradient_border.b-sprite-3.ds-traveller-header.bigblue_std_sm.bigblue_std_lg.lp_body_constraint_static.sb_can_have_advanced_search.system-font.iq-x-bar.iq-x-bar-new.iq-xp-sb:nth-child(2) div.b9720ed41e.cdf0a9297c:nth-child(212) div.eb33ef7c47 div.f0c216ee26.c676dd76fe.b5018b639f div.c0528ecc22 div.dd5dccd82f div.ffd93a9ecb.dc19f70f85.eb67815534 div.abcc616ec7.cc1b961f14.c180176d40.f11eccb5e8.ff74db973c button.a83ed08757.c21c56c305.f38b6daa18.d691166b09.ab98298258.f4552b6561 span.eedba9e88a span.fcd9eec8fb.bf9a32efa5 svg:nth-child(1) > path:nth-child(1)"));
            Cross.Click();
            Thread.Sleep(2000);

            IWebElement Destination = driver.FindElement(By.XPath("//input[@id=':rh:']"));
            Destination.Click();
            Thread.Sleep(3000);

            IWebElement Location = driver.FindElement(By.XPath("//li[@id='autocomplete-result-0']//div[@class='b0eaf5262b']"));
            Location.Click();
            Thread.Sleep(3000);

            IWebElement CheckIn = driver.FindElement(By.XPath("//span[normalize-space()='Check-in date']"));
            CheckIn.Click();
            Thread.Sleep(3000);

            IWebElement CheckInDate = driver.FindElement(By.XPath("(//td[@class = 'b80d5adb18'])[26]"));
            CheckInDate.Click();
            Thread.Sleep(3000);

            /*IWebElement CheckOut = driver.FindElement(By.XPath("//span[normalize-space()='Check-out date']"));
            CheckOut.Click();*/

            IWebElement CheckOutDate = driver.FindElement(By.XPath("(//td[@class = 'b80d5adb18'])[27]"));
            CheckOutDate.Click();
            Thread.Sleep(3000);

            IWebElement Peoples = driver.FindElement(By.XPath("//button[@class='a83ed08757 ebbedaf8ac dbaff8df6f ada2387af8']"));
            Peoples.Click();
            Thread.Sleep(3000);

            IWebElement Adults = driver.FindElement(By.XPath("(//button[@type='button'])[7]"));
            Adults.Click();
            Thread.Sleep(3000);

            IWebElement Done1 = driver.FindElement(By.XPath("//button[@class='a83ed08757 c21c56c305 bf0537ecb5 ab98298258 a2abacf76b af7297d90d c213355c26 b9fd3c6b3c']"));
            Done1.Click();
            Thread.Sleep(3000);

            IWebElement Search = driver.FindElement(By.XPath("//button[@type='submit']"));
            Search.Click();
            Thread.Sleep(3000);

            IWebElement Avalability = driver.FindElement(By.XPath("((//a[@class='a83ed08757 c21c56c305 a4c1805887 d691166b09 ab98298258 c082d89982 ff33faec5f'])[1]"));
            Avalability.Click();
            Thread.Sleep(3000);

            IWebElement ReserveRoom = driver.FindElement(By.XPath("(//select[@id='hprt_nos_select_1088429801_391244558_0_2_0'])[1]"));
            ReserveRoom.Click();
            Thread.Sleep(3000);

            IWebElement NoOfRooms = driver.FindElement(By.XPath("//td[@class='hp-price-left-align hprt-table-cell hprt-table-cell-price   droom_seperator hprt-remove-top-border']"));
            NoOfRooms.Click();
            Thread.Sleep(3000);

            IWebElement IllReserve = driver.FindElement(By.XPath("//button[@id='b_tt_holder_3']"));
            IllReserve.Click();
            Thread.Sleep(3000);
        }
    }
}
