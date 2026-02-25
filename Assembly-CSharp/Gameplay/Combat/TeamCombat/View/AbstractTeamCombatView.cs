using System;
using System.Collections.Generic;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.TeamCombat.View
{
	// Token: 0x0200098D RID: 2445
	[Token(Token = "0x200098D")]
	public abstract class AbstractTeamCombatView<TPlayerData> : AbstractCombatView where TPlayerData : CombatPlayer
	{
		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B6A")]
		public GameObject[] HideInstantElements
		{
			[Token(Token = "0x6003A53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B6B")]
		public GameObject[] DestroyInstantElements
		{
			[Token(Token = "0x6003A54")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A55")]
		public virtual ICombatPLayerView AddPlayer(TPlayerData player)
		{
			return null;
		}

		// Token: 0x06003A56 RID: 14934
		[Token(Token = "0x6003A56")]
		protected abstract ICombatPLayerView CreatePlayerView(TPlayerData player);

		// Token: 0x06003A57 RID: 14935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A57")]
		public virtual void RemovePlayer(TPlayerData player)
		{
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A58")]
		protected AbstractTeamCombatView()
		{
		}

		// Token: 0x0400202D RID: 8237
		[Token(Token = "0x400202D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject[] _hideInstantElements;

		// Token: 0x0400202E RID: 8238
		[Token(Token = "0x400202E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject[] _destroyInstantElements;

		// Token: 0x0400202F RID: 8239
		[Token(Token = "0x400202F")]
		[FieldOffset(Offset = "0x0")]
		protected List<ICombatPLayerView> _players;
	}
}
