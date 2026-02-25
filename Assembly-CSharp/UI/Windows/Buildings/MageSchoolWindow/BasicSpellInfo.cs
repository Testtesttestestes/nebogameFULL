using System;
using AssetContent;
using Gameplay.School.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements;
using UnityEngine;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public class BasicSpellInfo : MonoBehaviourWithStates<BasicSpellInfo.State>
	{
		// Token: 0x06001071 RID: 4209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x626E", Offset = "0x626E", VA = "0x626E")]
		public void Init(SchoolSpellData spellData)
		{
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x626F", Offset = "0x626F", VA = "0x626F", Slot = "4")]
		protected override void HandleCurrentStateChanged(BasicSpellInfo.State fromState, BasicSpellInfo.State toState)
		{
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x6270", Offset = "0x6270", VA = "0x6270")]
		public BasicSpellInfo()
		{
		}

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _currentLevel;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _nextLevel;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DecoratedTitle _title;

		// Token: 0x020002BB RID: 699
		[Token(Token = "0x20002BB")]
		public enum State
		{
			// Token: 0x04000870 RID: 2160
			[Token(Token = "0x4000870")]
			UNKNOWN_STATE,
			// Token: 0x04000871 RID: 2161
			[Token(Token = "0x4000871")]
			DEFAULT,
			// Token: 0x04000872 RID: 2162
			[Token(Token = "0x4000872")]
			EMPTY,
			// Token: 0x04000873 RID: 2163
			[Token(Token = "0x4000873")]
			MAX_LEVEL
		}
	}
}
