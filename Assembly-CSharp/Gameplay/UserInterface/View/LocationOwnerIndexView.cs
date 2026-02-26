using System;
using Gameplay.UserInterface.Control;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	public class LocationOwnerIndexView : MonoBehaviour
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003BF")]
		public UserIndexView UserIndexView
		{
			[Token(Token = "0x6001677")]
			[Address(RVA = "0x6838", Offset = "0x6838", VA = "0x6838")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C0")]
		public ClanIndexView ClanIndexView
		{
			[Token(Token = "0x6001678")]
			[Address(RVA = "0x6839", Offset = "0x6839", VA = "0x6839")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C1")]
		public Button RatingButton
		{
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x683A", Offset = "0x683A", VA = "0x683A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x683B", Offset = "0x683B", VA = "0x683B")]
		public void Init(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x683C", Offset = "0x683C", VA = "0x683C")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x683D", Offset = "0x683D", VA = "0x683D")]
		public LocationOwnerIndexView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_LocationOwnerIndexView___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar3 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar3 + 0xc),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)(*(int *)(iVar3 + 8) == param2),0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserIndexView _userIndexView;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ClanIndexView _clanIndexView;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _ratingButton;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x1C")]
		private LocationOwnerIndexViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RatingButton ---
		void Gameplay_UserInterface_View_LocationOwnerIndexView__get_RatingButton
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5825d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_TypeInfo);
		    DAT_ram_00a5825d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_TypeInfo
		                               );
		  Gameplay_UserInterface_Events_UserInterfaceEvents___ctor(param1_00,param2,param3,param4,0);
		  *(int **)(param1 + 0x1c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
