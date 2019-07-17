using DesignPatternsDemo.StructuralPattern.DecoratorPattern;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern
{
    public class DecoratorPatternTests
    {
        [Fact]
        public void ShouldGetZhaoJunBaseAttack()
        {
            var zhaoJunHero = new ZhaoJunHero();

            Assert.Equal("base attack by snow", zhaoJunHero.GetAttackDescription());

            Assert.Equal(1, zhaoJunHero.Attack());
        }

        [Fact]
        public void ShouldGetZhouYuHeroBaseAttack()
        {
            var zhouYuHero = new ZhouYuHero();

            Assert.Equal("base attack by fire", zhouYuHero.GetAttackDescription());

            Assert.Equal(1.2, zhouYuHero.Attack());
        }

        [Fact]
        public void ShouldGetZhaoJunHeroWithWandAttack()
        {
            var zhouYuHero = new WandEquipmentDecorator(new ZhouYuHero());

            Assert.Equal("base attack by fire, wand", zhouYuHero.GetAttackDescription());

            Assert.Equal(6.2, zhouYuHero.Attack());
        }

        [Fact]
        public void ShouldGetZhaoJunHeroWithWandAttackAndShoesAttack()
        {
            var zhaoJunHero = new ShoesEquipmentDecorator(new WandEquipmentDecorator(new ZhaoJunHero()));

            zhaoJunHero.GetAttackDescription();

            zhaoJunHero.Attack();
        }
        
        [Fact]
        public void ShouldGetZhaoJunHeroWithWandAttackAndTwoShoesAttack()
        {
            var zhaoJunHero = new WandEquipmentDecorator(new ShoesEquipmentDecorator(new ShoesEquipmentDecorator(new ShoesEquipmentDecorator(new ZhaoJunHero()))));

            Assert.Equal("base attack by snow, shoes, shoes, shoes, wand", zhaoJunHero.GetAttackDescription());

            Assert.Equal(12, zhaoJunHero.Attack());
        }
    }
}