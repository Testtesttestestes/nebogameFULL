using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Preloading;
using UnityEngine;

namespace UI.Preloader
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public class PreloaderBackgroundLoader : MonoBehaviour
	{
		// Token: 0x06000C16 RID: 3094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x5F29", Offset = "0x5F29", VA = "0x5F29")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Preloader_PreloaderBackgroundLoader__Awake
		               (undefined8 *param1,undefined4 param2,uint param3,undefined4 param4,undefined4 param5
		               )
		
		{
		  undefined8 local_40;
		  undefined4 local_34;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined4 uStack_24;
		  ulonglong local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a638fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_PreloaderBackgroundLoader__LoadBackground_d__4___
		              );
		    DAT_ram_00a638fb = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = (ulonglong)param3;
		  local_30 = 0;
		  local_34 = 0xffffffff;
		  _local_28 = CONCAT44(param2,param4);
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_PreloaderBackgroundLoader__LoadBackground_d__4___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_PreloaderBackgroundLoader__LoadBackground_d__4___
		              );
		  }
		  Utils_TimeUtils__get_UnixTimestampMilliseconds(&local_34,&local_40);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_40,&local_30,0);
		  *param1 = local_40;
		  return;
		}
		*/

		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x5F2A", Offset = "0x5F2A", VA = "0x5F2A")]
		private UniTask LoadBackground(string path, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: LoadBackground ---
		void UI_Preloader_PreloaderBackgroundLoader__LoadBackground(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x10),1,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x14),1,0);
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x5F2B", Offset = "0x5F2B", VA = "0x5F2B")]
		private void Launch()
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x5F2C", Offset = "0x5F2C", VA = "0x5F2C")]
		public PreloaderBackgroundLoader()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Preloader_PreloaderBackgroundLoader___ctor(int *param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a638fc == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3335);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7704);
		    DAT_ram_00a638fc = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if (StringLiteral_3335 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_3335,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_3335;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[4] = iVar3;
		  iVar3 = *param1;
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar3;
		  if (StringLiteral_7704 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_7704,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_7704;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[6] = iVar3;
		  local_8 = *(undefined8 *)(param1 + 2);
		  iVar3 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar3;
		  uVar2 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28692,param2_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PreloaderView _view;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Preloader _preloader;

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		public struct PreloaderBackgroundDto
		{
			// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x1D80", Offset = "0x1D80", VA = "0x1D80")]
			public PreloaderBackgroundDto(string assetPath, string htmlBackgroundColor, long expire)
			{
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x5F2D", Offset = "0x5F2D", VA = "0x5F2D", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			[FieldOffset(Offset = "0x0")]
			public string AssetPath;

			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			[FieldOffset(Offset = "0x8")]
			public long Expire;

			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x40005B6")]
			[FieldOffset(Offset = "0x10")]
			public string HtmlBackgroundColor;
		}
	}
}
