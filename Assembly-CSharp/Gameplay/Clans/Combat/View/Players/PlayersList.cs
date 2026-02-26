using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Combat.Model;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Clans.Combat.View.Players
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public class PlayersList : OSA<BaseParamsWithPrefab, PlayerViewsHolder>
	{
		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CDF")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6004146")]
			[Address(RVA = "0x8FFD", Offset = "0x8FFD", VA = "0x8FFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CE0")]
		public Dictionaries Dictionaries
		{
			[Token(Token = "0x6004147")]
			[Address(RVA = "0x8FFE", Offset = "0x8FFE", VA = "0x8FFE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE1")]
		public SimpleDataHelper<CombatPlayer> Data
		{
			[Token(Token = "0x6004148")]
			[Address(RVA = "0x8FFF", Offset = "0x8FFF", VA = "0x8FFF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004149")]
			[Address(RVA = "0x9000", Offset = "0x9000", VA = "0x9000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x9001", Offset = "0x9001", VA = "0x9001")]
		public void Setup(IGameAudio audio, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Setup ---
		void Gameplay_Clans_Combat_View_Players_PlayersList__Setup(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57785 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__TypeInfo);
		    DAT_ram_00a57785 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__TypeInfo)
		  ;
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer___ctor__);
		  *(undefined4 *)(param1 + 0xa8) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__Start__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x9002", Offset = "0x9002", VA = "0x9002", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Clans_Combat_View_Players_PlayersList__Start
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a57786 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_View_Players_PlayerViewsHolder_TypeInfo);
		    DAT_ram_00a57786 = '\x01';
		  }
		  uVar1 = *(undefined8 *)(param1 + 0xa0);
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Combat_View_Players_PlayerViewsHolder_TypeInfo);
		  *(undefined8 *)(param1_00 + 0x14) = uVar1;
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x9003", Offset = "0x9003", VA = "0x9003", Slot = "99")]
		protected override PlayerViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Clans_Combat_View_Players_PlayersList__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57787 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__get_Item__)
		    ;
		    DAT_ram_00a57787 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa8);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar2 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar2,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__get_Item__
		                    );
		  if (DAT_ram_00a57783 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a57783 = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)param2[7];
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x108);
		        goto code_r0x80dd8697;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,9)
		  ;
		code_r0x80dd8697:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,puVar3[1]);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x9004", Offset = "0x9004", VA = "0x9004", Slot = "100")]
		protected override void UpdateViewsHolder(PlayerViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Clans_Combat_View_Players_PlayersList__UpdateViewsHolder(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57788 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__OnDestroy__
		              );
		    DAT_ram_00a57788 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0xa0) = 0;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___OnCumulatedSizesOfAllItemsChanged
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder__OnDestroy__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x9005", Offset = "0x9005", VA = "0x9005", Slot = "73")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Combat_View_Players_PlayersList__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57789 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder___ctor__
		              );
		    DAT_ram_00a57789 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__PlayerViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414F")]
		[Address(RVA = "0x9006", Offset = "0x9006", VA = "0x9006")]
		public PlayersList()
		{
		}

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0xA0")]
		private IGameAudio _gameAudio;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0xA4")]
		private Dictionaries _dictionaries;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Clans_Combat_View_Players_PlayersList__set_Data
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0xa4) = param3;
		  *(undefined4 *)(param1 + 0xa0) = param2;
		  return;
		}
		*/

}
