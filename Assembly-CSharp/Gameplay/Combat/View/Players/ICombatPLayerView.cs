using System;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094F RID: 2383
	[Token(Token = "0x200094F")]
	public interface ICombatPLayerView
	{
		// Token: 0x06003865 RID: 14437
		[Token(Token = "0x6003865")]
		ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries);

		// Token: 0x06003866 RID: 14438
		[Token(Token = "0x6003866")]
		void UpdateUserSkill(UserSkillsIndexes skillsIndex);

		// Token: 0x06003867 RID: 14439
		[Token(Token = "0x6003867")]
		void UpdateBalance();

		// Token: 0x06003868 RID: 14440
		[Token(Token = "0x6003868")]
		void UpdateLongEffects();

		// Token: 0x06003869 RID: 14441
		[Token(Token = "0x6003869")]
		void ShowDeathState(float value, float duration = 0f);

		// Token: 0x0600386A RID: 14442
		[Token(Token = "0x600386A")]
		bool TryGetLevel(out LevelView levelView);

		// Token: 0x0600386B RID: 14443
		[Token(Token = "0x600386B")]
		bool TryGetPet(out IPetView petView);

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600386C RID: 14444
		[Token(Token = "0x17000B1E")]
		bool IsInit { [Token(Token = "0x600386C")] get; }

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600386D RID: 14445
		// (set) Token: 0x0600386E RID: 14446
		[Token(Token = "0x17000B1F")]
		CombatPlayer Player { [Token(Token = "0x600386D")] get; [Token(Token = "0x600386E")] set; }

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600386F RID: 14447
		[Token(Token = "0x17000B20")]
		GameObject gameObject { [Token(Token = "0x600386F")] get; }

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06003870 RID: 14448
		// (set) Token: 0x06003871 RID: 14449
		[Token(Token = "0x17000B21")]
		bool Select { [Token(Token = "0x6003870")] get; [Token(Token = "0x6003871")] set; }
	}
}
