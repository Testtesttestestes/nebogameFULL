using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000871 RID: 2161
	[Token(Token = "0x2000871")]
	public class DailyQuestsListAdapter : OSA<BaseParamsWithPrefab, DailyQuestsViewsHolder>
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A00")]
		public SimpleDataHelper<DailyQuestsListElementArgs> Data
		{
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x830E", Offset = "0x830E", VA = "0x830E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x830F", Offset = "0x830F", VA = "0x830F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BE")]
		[Address(RVA = "0x8310", Offset = "0x8310", VA = "0x8310", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_DailyQuests_View_DailyQuestsListAdapter__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57c1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__ResetItems__
		              );
		    DAT_ram_00a57c1d = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BF")]
		[Address(RVA = "0x8311", Offset = "0x8311", VA = "0x8311")]
		public void SetItems(IList<DailyQuestsListElementArgs> items)
		{
		/* --- GHIDRA: SetItems ---
		undefined4
		Gameplay_DailyQuests_View_DailyQuestsListAdapter__SetItems
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c1e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestsViewsHolder_TypeInfo);
		    DAT_ram_00a57c1e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_DailyQuests_View_DailyQuestsViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x8312", Offset = "0x8312", VA = "0x8312", Slot = "99")]
		protected override DailyQuestsViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_DailyQuests_View_DailyQuestsListAdapter__CreateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57c1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder__OnBeforeRecycleOrDisableViewsHolder__
		              );
		    DAT_ram_00a57c1f = '\x01';
		  }
		  Gameplay_DailyQuests_View_DailyQuestsListElement__Awake(*(undefined4 *)(param2 + 0x14),0,param2);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___OnBeforeDestroyViewsHolder
		            (param1,param2,param3,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder__OnBeforeRecycleOrDisableViewsHolder__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x8313", Offset = "0x8313", VA = "0x8313", Slot = "104")]
		protected override void OnBeforeRecycleOrDisableViewsHolder(DailyQuestsViewsHolder inRecycleBinOrVisible, int newItemIndex)
		{
		/* --- GHIDRA: OnBeforeRecycleOrDisableViewsHolder ---
		void Gameplay_DailyQuests_View_DailyQuestsListAdapter__OnBeforeRecycleOrDisableViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57c20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__get_Item__
		              );
		    DAT_ram_00a57c20 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__get_Item__
		                    );
		  param1_01 = param2[5];
		  if (DAT_ram_00a57c26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_Initted__
		              );
		    DAT_ram_00a57c26 = '\x01';
		  }
		  if (*(char *)(param1_01 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1_01,uVar1,
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__Init__)
		    ;
		    return;
		  }
		  Gameplay_DailyQuests_View_DailyQuestsListElement__Awake(param1_01,uVar1,param1_01);
		  Gameplay_DailyQuests_View_DailyQuestsListElement__OnInit(param1_01,param1_01);
		  return;
		}
		*/

		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x8314", Offset = "0x8314", VA = "0x8314", Slot = "100")]
		protected override void UpdateViewsHolder(DailyQuestsViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_DailyQuests_View_DailyQuestsListAdapter__UpdateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder___ctor__
		              );
		    DAT_ram_00a57c21 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x8315", Offset = "0x8315", VA = "0x8315")]
		public DailyQuestsListAdapter()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_DailyQuests_View_DailyQuestsListAdapter___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a57c25 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    DAT_ram_00a57c25 = '\x01';
		  }
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_DailyQuests_View_DailyQuestsListAdapter__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__TypeInfo
		              );
		    DAT_ram_00a57c1c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder__Start__
		            );
		  return;
		}
		*/

}
