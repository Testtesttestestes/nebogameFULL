using System;
using System.Collections;
using Core.Data.Skills;
using Gameplay.Combat.View.GameField;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;

namespace Gameplay.Combat.View.StoneValuesWidget
{
	// Token: 0x0200093B RID: 2363
	[Token(Token = "0x200093B")]
	public class StoneValuesWidgetView : MonoBehaviour
	{
		// Token: 0x060037D3 RID: 14291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x87B5", Offset = "0x87B5", VA = "0x87B5")]
		public void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Combat_View_StoneValuesWidget_StoneValuesWidgetView__Start
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a566d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_StoneValuesWidget_StoneValuesWidgetView__Draw_d__6_TypeInfo);
		    DAT_ram_00a566d9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Combat_View_StoneValuesWidget_StoneValuesWidgetView__Draw_d__6_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x87B6", Offset = "0x87B6", VA = "0x87B6")]
		private IEnumerator Draw()
		{
			return null;
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x87B7", Offset = "0x87B7", VA = "0x87B7")]
		public StoneValuesWidgetView()
		{
		}

		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StoneValuesWidgetRowView _rowPrefab;

		// Token: 0x04001EDD RID: 7901
		[Token(Token = "0x4001EDD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _owner;

		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameFieldMono _gameField;

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private StoneValuesWidgetView.StoneSkillSpriteConfig[] _stoneSkillSpriteConfigs;

		// Token: 0x0200093C RID: 2364
		[Token(Token = "0x200093C")]
		[Serializable]
		public class StoneSkillSpriteConfig
		{
			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x060037D6 RID: 14294 RVA: 0x0000B328 File Offset: 0x00009528
			[Token(Token = "0x17000B05")]
			public StonesTypes StonesType
			{
				[Token(Token = "0x60037D6")]
				[Address(RVA = "0x87B8", Offset = "0x87B8", VA = "0x87B8")]
				get
				{
					return StonesTypes.Empty;
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x060037D7 RID: 14295 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000B06")]
			public Sprite SkillSprite
			{
				[Token(Token = "0x60037D7")]
				[Address(RVA = "0x87B9", Offset = "0x87B9", VA = "0x87B9")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x060037D8 RID: 14296 RVA: 0x0000B340 File Offset: 0x00009540
			[Token(Token = "0x17000B07")]
			public UserSkillsIndexes Skillndex
			{
				[Token(Token = "0x60037D8")]
				[Address(RVA = "0x87BA", Offset = "0x87BA", VA = "0x87BA")]
				get
				{
					return UserSkillsIndexes.EXTRA_HEALTH_CURRENT_SKILL;
				}
			}

			// Token: 0x060037D9 RID: 14297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60037D9")]
			[Address(RVA = "0x87BB", Offset = "0x87BB", VA = "0x87BB")]
			public StoneSkillSpriteConfig()
			{
			}

			// Token: 0x04001EE0 RID: 7904
			[Token(Token = "0x4001EE0")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private StonesTypes _stonesType;

			// Token: 0x04001EE1 RID: 7905
			[Token(Token = "0x4001EE1")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Sprite _skillSprite;

			// Token: 0x04001EE2 RID: 7906
			[Token(Token = "0x4001EE2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UserSkillsIndexes _skillndex;
		}
	}
}
