using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C42 RID: 3138
	[Token(Token = "0x2000C42")]
	public class BankOsaView : OSA<BaseParamsWithPrefab, BankOptionViewHolder>
	{
		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06004C8C RID: 19596 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004C8D RID: 19597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6D")]
		public SimpleDataHelper<BankOptionViewArgs> Data
		{
			[Token(Token = "0x6004C8C")]
			[Address(RVA = "0x9ACD", Offset = "0x9ACD", VA = "0x9ACD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C8D")]
			[Address(RVA = "0x9ACE", Offset = "0x9ACE", VA = "0x9ACE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x9ACF", Offset = "0x9ACF", VA = "0x9ACF", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4 Gameplay_Bank_View_BankOsaView__Start(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5978e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_BankOptionViewHolder_TypeInfo);
		    DAT_ram_00a5978e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Bank_View_BankOptionViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x9AD0", Offset = "0x9AD0", VA = "0x9AD0", Slot = "99")]
		protected override BankOptionViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Bank_View_BankOsaView__CreateViewsHolder(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5978f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__get_Item__
		              );
		    DAT_ram_00a5978f = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__get_Item__
		                    );
		  iVar2 = *(int *)param2[5];
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            ((int *)param2[5],uVar1,*(undefined4 *)(iVar2 + 0x13c));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x9AD1", Offset = "0x9AD1", VA = "0x9AD1", Slot = "100")]
		protected override void UpdateViewsHolder(BankOptionViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Bank_View_BankOsaView__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59790 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__InsertItems__
		              );
		    DAT_ram_00a59790 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x9AD2", Offset = "0x9AD2", VA = "0x9AD2")]
		public void AddItemsAt(int index, IList<BankOptionViewArgs> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Bank_View_BankOsaView__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59791 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__RemoveItems__
		              );
		    DAT_ram_00a59791 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x9AD3", Offset = "0x9AD3", VA = "0x9AD3")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Bank_View_BankOsaView__RemoveItemsFrom
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59792 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__ResetItems__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__get_Count__
		              );
		    DAT_ram_00a59792 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x28],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__ResetItems__
		            );
		  iVar1 = UnityEngine_AndroidJavaObject___GetRawObject
		                    (param1[0x28],
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__get_Count__
		                    );
		  if (0 < iVar1) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x390) * 4))
		              (param1,0,0,0,*(undefined4 *)(*param1 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x9AD4", Offset = "0x9AD4", VA = "0x9AD4")]
		public void SetItems(IList<BankOptionViewArgs> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Bank_View_BankOsaView__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59793 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionViewHolder___ctor__
		              );
		    DAT_ram_00a59793 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x9AD5", Offset = "0x9AD5", VA = "0x9AD5")]
		public BankOsaView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Bank_View_BankOsaView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5978d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionViewHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__TypeInfo);
		    DAT_ram_00a5978d = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417
		                          (
		                          Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs__TypeInfo
		                          );
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (param1_00,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionViewArgs___ctor__
		              );
		    *(undefined4 *)(param1 + 0xa0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionViewHolder__Start__
		              );
		  }
		  return;
		}
		*/

}
