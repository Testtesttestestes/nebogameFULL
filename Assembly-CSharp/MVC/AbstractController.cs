using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace MVC
{
	// Token: 0x02000E39 RID: 3641
	[Token(Token = "0x2000E39")]
	public abstract class AbstractController : IDisposable
	{
		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		// (set) Token: 0x06005938 RID: 22840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700122F")]
		public bool IsRun
		{
			[Token(Token = "0x6005937")]
			[Address(RVA = "0xA688", Offset = "0xA688", VA = "0xA688")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005938")]
			[Address(RVA = "0xA689", Offset = "0xA689", VA = "0xA689")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06005939 RID: 22841 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		// (set) Token: 0x0600593A RID: 22842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001230")]
		public bool IsInit
		{
			[Token(Token = "0x6005939")]
			[Address(RVA = "0xA68A", Offset = "0xA68A", VA = "0xA68A")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600593A")]
			[Address(RVA = "0xA68B", Offset = "0xA68B", VA = "0xA68B")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600593B RID: 22843 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		// (set) Token: 0x0600593C RID: 22844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001231")]
		public bool IsDisposed
		{
			[Token(Token = "0x600593B")]
			[Address(RVA = "0xA68C", Offset = "0xA68C", VA = "0xA68C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600593C")]
			[Address(RVA = "0xA68D", Offset = "0xA68D", VA = "0xA68D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593D")]
		[Address(RVA = "0xA68E", Offset = "0xA68E", VA = "0xA68E", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void MVC_AbstractController__Dispose(int *param1,undefined4 param2)
		
		{
		  if ((char)param1[2] == '\0') {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))(param1,*(undefined4 *)(*param1 + 0xfc));
		    *(undefined1 *)(param1 + 2) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593E")]
		[Address(RVA = "0xA68F", Offset = "0xA68F", VA = "0xA68F")]
		public void Run()
		{
		/* --- GHIDRA: Run ---
		void MVC_AbstractController__Run(int *param1,undefined4 param2)
		
		{
		  if ((char)param1[2] != '\0') {
		    Utils_OpTokenRepository__Remove(param1[3],0);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,*(undefined4 *)(*param1 + 0xf4));
		    *(undefined2 *)(param1 + 2) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593F")]
		[Address(RVA = "0xA690", Offset = "0xA690", VA = "0xA690")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void MVC_AbstractController__Stop(int param1,undefined4 param2)
		
		{
		  Utils_OpTokenRepository__Remove(*(undefined4 *)(param1 + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x06005940 RID: 22848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005940")]
		[Address(RVA = "0xA691", Offset = "0xA691", VA = "0xA691")]
		private void CancelRequests()
		{
		/* --- GHIDRA: CancelRequests ---
		void MVC_AbstractController__CancelRequests(int param1,undefined4 param2,undefined4 param3)
		
		{
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0xc),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005941")]
		[Address(RVA = "0x1AEF", Offset = "0x1AEF", VA = "0x1AEF")]
		protected void AddRequestToken(IOpToken token)
		{
		/* --- GHIDRA: AddRequestToken ---
		void MVC_AbstractController__AddRequestToken(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54ed4 == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item(&ICSharpCode_SharpZipLib_Checksum_Crc32_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&ICSharpCode_SharpZipLib_Zip_Compression_Streams_DeflaterOutputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ICSharpCode_SharpZipLib_Zip_Compression_Deflater_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ZipEntry___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ZipEntry__TypeInfo);
		    DAT_ram_00a54ed4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ZipEntry__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ZipEntry___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  uVar1 = unnamed_function_1417(ICSharpCode_SharpZipLib_Checksum_Crc32_TypeInfo);
		  ICSharpCode_SharpZipLib_Checksum_Crc32___ctor(uVar1,0);
		  *(undefined8 *)(param1 + 0x40) = 0x8ffffffff;
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = Mono_Security_ASN1Convert__ToOid(byte___TypeInfo,0);
		  *(undefined8 *)(param1 + 0x60) = 0xffffffffffffffff;
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  *(undefined8 *)(param1 + 0x68) = 0xffffffffffffffff;
		  *(undefined4 *)(param1 + 0x70) = 2;
		  uVar1 = unnamed_function_1417(ICSharpCode_SharpZipLib_Zip_Compression_Deflater_TypeInfo);
		  ICSharpCode_SharpZipLib_Zip_ZipStrings__ConvertToArray(uVar1,0xffffffff,1,param1);
		  if (*(int *)(ICSharpCode_SharpZipLib_Zip_Compression_Streams_DeflaterOutputStream_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(ICSharpCode_SharpZipLib_Zip_Compression_Streams_DeflaterOutputStream_TypeInfo);
		  }
		  ICSharpCode_SharpZipLib_Zip_Compression_Streams_DeflaterOutputStream___ctor
		            (param1,param2,uVar1,0x200,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005942")]
		[Address(RVA = "0xA692", Offset = "0xA692", VA = "0xA692")]
		protected void RemoveRequestToken(IOpToken token)
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005943")]
		[Address(RVA = "0xA693", Offset = "0xA693", VA = "0xA693", Slot = "6")]
		protected virtual void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void MVC_AbstractController__HandleStop(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c0c == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a63c0c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005944")]
		[Address(RVA = "0x36D6", Offset = "0x36D6", VA = "0x36D6", Slot = "7")]
		protected virtual void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void MVC_AbstractController__HandleRun(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x03') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x34;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x33;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x32;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x31;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x30;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x04') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x2f;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Animat_ram_00003c66 + 0x35;
		  return;
		}
		*/

		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005945")]
		[Address(RVA = "0xA694", Offset = "0xA694", VA = "0xA694")]
		protected AbstractController()
		{
		}

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0xC")]
		private readonly OpTokenRepository _tokenRepository;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsDisposed ---
		void MVC_AbstractController__set_IsDisposed(int param1,undefined4 param2)
		
		{
		  Utils_OpToken__Cancel(*(undefined4 *)(param1 + 0xc),0);
		  *(undefined1 *)(param1 + 10) = 1;
		  return;
		}
		*/

}
